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
        public float AirTemperature { get; set; }
        public float AirTemperature80m { get; set; }
        public float AirTemperature100m { get; set; }
        public float AirTemperature1000hpa { get; set; }
        public float AirTemperature800hpa { get; set; }
        public float AirTemperature500hpa { get; set; }
        public float AirTemperature200hpa { get; set; }
        public float Pressure { get; set; }
        public float CloudCover { get; set; }
        public float CurrentDirection { get; set; }
        public float CurrentSpeed { get; set; }
        public float Gust { get; set; }
        public float Humidity { get; set; }
        public float IceCover { get; set; }
        public float Precipitation { get; set; }
        public float SnowDepth { get; set; }
        public float SeaLevel { get; set; }
        public float SwellDirection { get; set; }
        public float SwellHeight { get; set; }
        public float SwellPeriod { get; set; }
        public float SecondarySwellPeriod { get; set; }
        public float SecondarySwellDirection { get; set; }
        public float SecondarySwellHeight { get; set; }
        public float Visibility { get; set; }
        public float WaterTemperature { get; set; }
        public float WaveDirection { get; set; }
        public float WaveHeight { get; set; }
        public float WavePeriod { get; set; }
        public float WindWaveDirection { get; set; }
        public float WindWaveHeight { get; set; }
        public float WindWavePeriod { get;set; }
        public float WindDirection { get; set; }
        public float WindDirection20m { get; set; }
        public float WindDirection30m { get; set; }
        public float WindDirection40m { get; set; }
        public float WindDirection50m { get; set; }
        public float WindDirection80m { get; set; }
        public float WindDirection100m { get; set; }
        public float WindDirection1000hpa { get; set; }
        public float WindDirection800hpa { get; set; }
        public float WindDirection500hpa { get; set; }
        public float WindDirection200hpa { get; set; }
        public float WindSpeed { get; set; }
        public float WindSpeed20m { get; set; }
        public float WindSpeed30m { get; set; }
        public float WindSpeed40m { get; set; }
        public float WindSpeed50m { get; set; }
        public float WindSpeed80m { get; set; }
        public float WindSpeed100m { get; set; }
        public float WindSpeed1000hpa { get; set; }
        public float WindSpeed800hpa { get; set; }
        public float WindSpeed500hpa { get; set; }
        public float WindSpeed200hpa { get; set; }

        public WeatherHour(DateTime time, float airTemperature, float airTemperature80m, float airTemperature100m, float airTemperature1000hpa, float airTemperature800hpa, float airTemperature500hpa, float airTemperature200hpa, float pressure, float cloudCover, float currentDirection, float currentSpeed, float gust, float humidity, float iceCover, float precipitation, float snowDepth, float seaLevel, float swellDirection, float swellHeight, float swellPeriod, float secondarySwellPeriod, float secondarySwellDirection, float secondarySwellHeight, float visibility, float waterTemperature, float waveDirection, float waveHeight, float wavePeriod, float windWaveDirection, float windWaveHeight, float windWavePeriod, float windDirection, float windDirection20m, float windDirection30m, float windDirection40m, float windDirection50m, float windDirection80m, float windDirection100m, float windDirection1000hpa, float windDirection800hpa, float windDirection500hpa, float windDirection200hpa, float windSpeed, float windSpeed20m, float windSpeed30m, float windSpeed40m, float windSpeed50m, float windSpeed80m, float windSpeed100m, float windSpeed1000hpa, float windSpeed800hpa, float windSpeed500hpa, float windSpeed200hpa)
        {
            Time = time;
            AirTemperature = airTemperature;
            AirTemperature80m = airTemperature80m;
            AirTemperature100m = airTemperature100m;
            AirTemperature1000hpa = airTemperature1000hpa;
            AirTemperature800hpa = airTemperature800hpa;
            AirTemperature500hpa = airTemperature500hpa;
            AirTemperature200hpa = airTemperature200hpa;
            Pressure = pressure;
            CloudCover = cloudCover;
            CurrentDirection = currentDirection;
            CurrentSpeed = currentSpeed;
            Gust = gust;
            Humidity = humidity;
            IceCover = iceCover;
            Precipitation = precipitation;
            SnowDepth = snowDepth;
            SeaLevel = seaLevel;
            SwellDirection = swellDirection;
            SwellHeight = swellHeight;
            SwellPeriod = swellPeriod;
            SecondarySwellPeriod = secondarySwellPeriod;
            SecondarySwellDirection = secondarySwellDirection;
            SecondarySwellHeight = secondarySwellHeight;
            Visibility = visibility;
            WaterTemperature = waterTemperature;
            WaveDirection = waveDirection;
            WaveHeight = waveHeight;
            WavePeriod = wavePeriod;
            WindWaveDirection = windWaveDirection;
            WindWaveHeight = windWaveHeight;
            WindWavePeriod = windWavePeriod;
            WindDirection = windDirection;
            WindDirection20m = windDirection20m;
            WindDirection30m = windDirection30m;
            WindDirection40m = windDirection40m;
            WindDirection50m = windDirection50m;
            WindDirection80m = windDirection80m;
            WindDirection100m = windDirection100m;
            WindDirection1000hpa = windDirection1000hpa;
            WindDirection800hpa = windDirection800hpa;
            WindDirection500hpa = windDirection500hpa;
            WindDirection200hpa = windDirection200hpa;
            WindSpeed = windSpeed;
            WindSpeed20m = windSpeed20m;
            WindSpeed30m = windSpeed30m;
            WindSpeed40m = windSpeed40m;
            WindSpeed50m = windSpeed50m;
            WindSpeed80m = windSpeed80m;
            WindSpeed100m = windSpeed100m;
            WindSpeed1000hpa = windSpeed1000hpa;
            WindSpeed800hpa = windSpeed800hpa;
            WindSpeed500hpa = windSpeed500hpa;
            WindSpeed200hpa = windSpeed200hpa;
        }
    }
}
