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
        public override string ToString()
        {
            StringBuilder sb= new StringBuilder(); 
            sb.AppendLine("Date: " + date.ToString());
            sb.AppendLine("Air Temp: " + airTemp.ToString());
            sb.AppendLine("Barometric Pressure: " + barometricPress.ToString());
            sb.AppendLine("Dew Point: " + dewPoint.ToString());
            sb.AppendLine("RelativeHumidity: " + RelativeHumidity.ToString());
            sb.AppendLine("Wind Direction: " + windDirection.ToString());
            sb.AppendLine("Wind Gust: " + windGust.ToString());
            sb.AppendLine("Wind Speed: " + windSpeed.ToString());
            return sb.ToString();
        }
    }
}
