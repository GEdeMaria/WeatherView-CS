using System.Diagnostics;
using GEM.API.Stormglass.Models;

namespace WeatherView
{
    public partial class Form1 : Form
    {
        private GEM.API.Stormglass.StormglassClient client;

        public Form1()
        {
            InitializeComponent();

            string[] keys = File.ReadAllLines($"{Application.StartupPath}/api.txt");
            foreach (string key in keys)
            {
                if (key.StartsWith("stormglass"))
                {
                    client = new GEM.API.Stormglass.StormglassClient(key.Substring(key.IndexOf(':') + 1));
                    break;
                }
            }

            if (client != null)
            {
                //var r = client.GetElevationResponse(new GEM.API.Stormglass.Models.ElevationRequest(0,0));
                //Debug.WriteLine(r.ToString());

                DateTime e = DateTime.Now;
                e.AddHours(4);

                string[] testCoords = File.ReadAllLines($"{Application.StartupPath}/loc.txt");

                var r = client.GetMiniWeatherResponse(
                    new MiniWeatherRequest(
                        Convert.ToSingle(testCoords[0]), 
                        Convert.ToSingle(testCoords[1]), 
                        DateTime.Now, e));
            }
        }
    }
}