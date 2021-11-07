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
            Console.WriteLine("test");
            DataParser parser = new DataParser(@"C:\Users\Jacob\source\repos\Pond Oreille\Pond Oreille\Environmental_Data_Deep_Moor_2012.txt");
        }
    }
}
