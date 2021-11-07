using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pond_Oreille
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Sanity Check");
            DataParser parser = new DataParser(@"C:\Users\Jacob\source\repos\Pond Oreille\Pond Oreille\Environmental_Data_Deep_Moor_2012.txt");
            DateTime lookupDate = DateTime.Parse("1/1/2012");
            DateTime lookupDate2 = DateTime.Parse("1/3/2012");
            List<WeatherData> wd = parser.findBetweenDate(lookupDate, lookupDate2);

            foreach( WeatherData data in wd)
            {
                Console.WriteLine(data);
            }
        }
    }
}
