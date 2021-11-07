using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pond_Oreille
{
    public class DataParser
    {
        List<WeatherData> data;
        public DataParser(string path)
        {
            data = new List<WeatherData>();
            CultureInfo us = new CultureInfo("en-US");
            string text = System.IO.File.ReadAllText(path);

            string[] tsplitData = text.Split('\n');
            List<string[]> splitData = new List<string[]>();

            for(int i = 0; i < tsplitData.Length; i++)
            {
                splitData.Add(tsplitData[i].Split('\t'));
            }
            //splitData.Count
            for (int i = 1; i < 4 ; i++)
            {
                WeatherData wd = new WeatherData();
                string tempDate = splitData[i][0] + splitData[i][1].Substring(4);
                DateTime date = DateTime.ParseExact(tempDate, "yyyy_MM_dd HH:mm:ss", us);
                wd.date = date;
                wd.airTemp = float.Parse(splitData[i][1].Substring(0,4));
                wd.barometricPress = float.Parse(splitData[i][2]);
                wd.dewPoint = float.Parse(splitData[i][3]);
                wd.RelativeHumidity = float.Parse(splitData[i][4]);
                wd.windDirection = float.Parse(splitData[i][5]);
                wd.windGust = float.Parse(splitData[i][6]);
                wd.windSpeed = float.Parse(splitData[i][7]);
                data.Add(wd);
            }
        }

        
    }
}
