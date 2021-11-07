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
            for (int i = 2; i < splitData.Count-3 ; i++)
            {
                WeatherData wd = new WeatherData();
                string test = splitData[i][0];
                DateTime date = DateTime.ParseExact(test, "yyyy_MM_dd HH:mm:ss", us);
                wd.date = date;
                wd.airTemp = float.Parse(splitData[i][1]);
                wd.barometricPress = float.Parse(splitData[i][2]);
                wd.dewPoint = float.Parse(splitData[i][3]);
                wd.RelativeHumidity = float.Parse(splitData[i][4]);
                wd.windDirection = float.Parse(splitData[i][5]);
                wd.windGust = float.Parse(splitData[i][6]);
                wd.windSpeed = float.Parse(splitData[i][7]);
                data.Add(wd);
            }
        }

        public List<WeatherData> findByDate(DateTime time)
        {
            return data.FindAll(d => time.Date == d.date.Date);
        }

        public List<WeatherData> findBetweenDate(DateTime d1, DateTime d2)
        {
            return data.FindAll(d => d1.Date <= d.date.Date && d2.Date >= d.date.Date);
        }
    }
}
