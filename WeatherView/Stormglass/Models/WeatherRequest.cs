using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEM.API.Stormglass.Models
{
    public class WeatherRequest
    {
        public WeatherRequest(float latitude, float longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public WeatherRequest(float latitude, float longitude, DateTime end)
        {
            Latitude = latitude;
            Longitude = longitude;
            End = end;
        }
        public WeatherRequest(float latitude, float longitude, string parameters, DateTime start, DateTime end, string source)
        {
            Latitude = latitude;
            Longitude = longitude;
            Parameters = parameters;
            Start = start;
            End = end;
            Source = source;
        }

        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public string Parameters { get; set; } = "time,airTemperature,airTemperature80m,airTemperature100m,airTemperature1000hpa,airTemperature800hpa,airTemperature500hpa,airTemperature200hpa,pressure,cloudCover,currentDirection,currentSpeed,gust,humidity,iceCover,precipitation,snowDepth,seaLevel,swellDirection,swellHeight,swellPeriod,secondarySwellPeriod,secondarySwellDirection,secondarySwellHeight,visibility,waterTemperature,waveDirection,waveHeight,wavePeriod,windWaveDirection,windWaveHeight,windWavePeriod,windDirection,windDirection20m,windDirection30m,windDirection40m,windDirection50m,windDirection80m,windDirection100m,windDirection1000hpa,windDirection800hpa,windDirection500hpa,windDirection200hpa,windSpeed,windSpeed20m,windSpeed30m,windSpeed40m,windSpeed50m,windSpeed80m,windSpeed100m,windSpeed1000hpa,windSpeed800hpa,windSpeed500hpa,windSpeed200hpa";
        public DateTime? Start { get; set; } = null;
        public DateTime? End { get; set; } = null;
        public string Source { get; set; } = string.Empty;

        public string RequestString()
        {
            string r = $"?lat={Latitude}&lng={Longitude}&params={Parameters}";
            if (Start != null) { r += $"&start={Start.Value.ToUniversalTime()}"; }
            if (End != null) { r += $"&end={End.Value.ToUniversalTime()}"; }
            if (Source != string.Empty) { r += $"&source={Source}"; }
            return r;
        } 
    }
}
