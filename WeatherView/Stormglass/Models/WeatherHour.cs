using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEM.API.Stormglass.Models
{
    public class WeatherHour
    {
        public DateTime Time { get; set; }
        public Dictionary<string, float> Data { get; set; }
        public WeatherHour(DateTime time) 
        {
            Time = time;
            Data = new Dictionary<string, float>();
        }
    }
}
