using GEM.API.Stormglass.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEM.API.Stormglass
{
    public class StormglassClient
    {
        public const string ENDPOINT = "https://api.stormglass.io/v2";
        public const string ENDPOINT_WEATHER = "/weather/point";
        public const string ENDPOINT_BIO = "/bio/point";
        public const string ENDPOINT_TIDE_EXTREMES = "/tide/extremes/point";
        public const string ENDPOINT_SEA_LEVEL = "/tide/sea-level/point";
        public const string ENDPOINT_STATION_LIST = "/tide/stations";
        public const string ENDPOINT_STATION_AREA = "/tide/stations/area";
        public const string ENDPOINT_ASTRONOMY = "/astronomy/point";
        public const string ENDPOINT_SOLAR = "/solar/point";
        public const string ENDPOINT_ELEVATION = "/elevation/point";

        private readonly string _key;
        private HttpClient client;

        private JObject getResponseBody(string url)
        {
            Debug.WriteLine($"getResponseBody({url})");
            url = url.Replace(" ", "+");
            Debug.WriteLine($"getResponseBody({url})");
            HttpResponseMessage response = client.GetAsync(url).Result;
            response.EnsureSuccessStatusCode();
            string body = response.Content.ReadAsStringAsync().Result;

            Debug.WriteLine(body);

            return JObject.Parse(body);
        }

        public StormglassClient(string key)
        {
            _key = key;
            client = new HttpClient();
            client.BaseAddress = new Uri(ENDPOINT);
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("Authorization", _key);
        }

        public MiniWeatherResponse GetMiniWeatherResponse(MiniWeatherRequest miniWeatherRequest)
        {
            var obj = getResponseBody(ENDPOINT + ENDPOINT_WEATHER + miniWeatherRequest.RequestString());


            throw new Exception();
        }

        public ElevationResponse GetElevationResponse(ElevationRequest elevationRequest)
        {
            var obj = getResponseBody(ENDPOINT + ENDPOINT_ELEVATION + elevationRequest.RequestString());
            return new ElevationResponse(
                obj["data"]["elevation"].Value<float>(),
                obj["meta"]["dailyQuota"].Value<int>(),
                obj["meta"]["requestCount"].Value<int>(),
                obj["meta"]["lat"].Value<float>(),
                obj["meta"]["lng"].Value<float>(),
                obj["meta"]["distance"].Value<float>(),
                obj["meta"]["elevation"]["unit"].Value<string>() ?? "ERROR READING UNITS",
                obj["meta"]["elevation"]["source"].Value<string>() ?? "ERROR READING SOURCE");
        }

    }
}
