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
            Parameters = new WeatherParameterTable();
            string[] strings = Properties.Resources.weatherParametersDefault.Split('\n');
            foreach (string s in strings)
                Parameters.Parameters[s] = true;
        }
        public WeatherRequest(float latitude, float longitude, DateTime end)
        {
            Latitude = latitude;
            Longitude = longitude;
            End = end;
            Parameters = new WeatherParameterTable();
            string[] strings = Properties.Resources.weatherParametersDefault.Split('\n');
            foreach (string s in strings)
                Parameters.Parameters[s] = true;
        }
        public WeatherRequest(float latitude, float longitude, WeatherParameterTable parameters, DateTime start, DateTime end, WeatherSources source)
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
        public WeatherParameterTable Parameters { get; set; }
        public DateTime? Start { get; set; } = null;
        public DateTime? End { get; set; } = null;
        public WeatherSources Source { get; set; } = WeatherSources.none;

        public string RequestString()
        {
            string r = $"?lat={Latitude}&lng={Longitude}&params={Parameters.GetParameters()}";
            if (Start != null) { r += $"&start={Start.Value.ToUniversalTime()}"; }
            if (End != null) { r += $"&end={End.Value.ToUniversalTime()}"; }
            if (Source != WeatherSources.none) { r += $"&source={Source}"; }
            return r;
        } 
    }
}
