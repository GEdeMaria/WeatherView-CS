using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GEM.API.Stormglass.Models
{
    public class WeatherParameterTable
    {
        public Dictionary<string, bool> Parameters { get; }

        public WeatherParameterTable(bool setAll = false)
        {

            string[] items = Properties.Resources.weatherParameters.Split('\n');

            Parameters = new Dictionary<string, bool>();

            foreach (string item in items)
            {
                Parameters.Add(item, setAll);
            }
        }

        /// <summary>
        /// Returns A List Of Parameters For Web API Request"
        /// </summary>
        /// <returns></returns>
        public string GetParameters()
        {
            string r = string.Empty;
            foreach (string k in Parameters.Keys)
            {
                if (Parameters[k] == true)
                {
                    if (r != string.Empty)
                        r += ",";
                    r += k;
                }
            }
            return r;
        }
    }
}
