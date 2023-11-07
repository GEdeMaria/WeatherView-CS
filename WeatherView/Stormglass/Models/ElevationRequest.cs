using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEM.API.Stormglass.Models
{
    public class ElevationRequest
    {
        public float Latitude { get; set; }
        public float Longitude { get; set; }
        public ElevationRequest() { }
        public ElevationRequest(float latitude, float longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }
        public string RequestString() => $"?lat={Latitude}&lng={Longitude}";
        public override string ToString()
        {
            return $"{nameof(ElevationRequest)}:{Latitude}, {Longitude}";
        }
    }
}
