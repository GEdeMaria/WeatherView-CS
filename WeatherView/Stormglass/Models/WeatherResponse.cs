using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEM.API.Stormglass.Models
{
    public class WeatherResponse
    {
        public WeatherHour[] Hours { get; set; }
        public int DailyQuota { get; set; }
        public int RequestCount { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }

        public WeatherResponse(WeatherHour[] hours, int dailyQuota, int requestCount, float latitude, float longitude)
        {
            Hours = hours;
            DailyQuota = dailyQuota;
            RequestCount = requestCount;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
