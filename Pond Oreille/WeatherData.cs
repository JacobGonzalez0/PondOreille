using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pond_Oreille
{
    public class WeatherData
    {
        public DateTime date { get; set; }
        public float airTemp { get; set; }
        public float barometricPress { get; set; }
        public float dewPoint { get; set; }
        public float RelativeHumidity { get; set; }
        public float windDirection { get; set; }
        public float windGust { get; set; }
        public float windSpeed { get; set; }
        public WeatherData()
        {

        }
    }
}
