using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEM.API.Stormglass.Models
{
    public class MiniWeatherRequest
    {
        public MiniWeatherRequest(float latitude, float longitude, DateTime start, DateTime end)
        {
            Latitude = latitude;
            Longitude = longitude;
            Start = start;
            End = end;
        }

        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public string RequestString()
        {
            // &start={Start.ToUniversalTime()}&end={End.ToUniversalTime()}
            return $"?lat={Latitude}&lng={Longitude}&params=time,airTemperature,cloudCover,gust,humidity,precipitation,visibility,windDirection,windSpeed";
        }
    }
}
