using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEM.API.Stormglass.Models
{
    public record ElevationResponse
    {
        public ElevationResponse(float elevation, int dailyQuota, int requestCount, float latitude, float longitude, float distance, string unit, string source)
        {
            Elevation = elevation;
            DailyQuota = dailyQuota;
            RequestCount = requestCount;
            Latitude = latitude;
            Longitude = longitude;
            Distance = distance;
            Unit = unit;
            Source = source;
        }

        public float Elevation { get; init; }
        public int DailyQuota { get; init; }
        public int RequestCount { get; init; }
        public float Latitude { get; init; }
        public float Longitude { get; init; }
        public float Distance { get; init; }
        public string Unit { get; init; }
        public string Source { get; init; }

        public override string ToString()
        {
            return $"Elevation:{Elevation} @{Latitude}, {Longitude}";
        }
    }
}
