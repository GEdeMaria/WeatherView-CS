using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEM.API.Stormglass.Models
{
    public class MiniWeatherHour
    {
        public DateTime Time { get; set; }
        public float AirTemperature { get; set; }
        public float CloudCover { get; set; }
        public float Gust { get; set; }
        public float Humidity { get; set; }
        public float Precipitation { get; set; }
        public float Visibility { get; set; }
        public float WindDirection { get; set; }
        public float WindSpeed { get; set; }
        public MiniWeatherHour() { }
        public MiniWeatherHour(DateTime time, float airTemperature, float cloudCover, float gust, float humidity, float precipitation, float visibility, float windDirection, float windSpeed)
        {
            Time = time;
            AirTemperature = airTemperature;
            CloudCover = cloudCover;
            Gust = gust;
            Humidity = humidity;
            Precipitation = precipitation;
            Visibility = visibility;
            WindDirection = windDirection;
            WindSpeed = windSpeed;
        }
    }
}
