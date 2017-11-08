using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _04_Weather
{
    public class StartUp
    {
        public static void Main()
        {
            List<WeatherForecast>forecasts=new List<WeatherForecast>();
            string input;

            while ((input=Console.ReadLine())!="end")
            {
                string pattern = @"([A-Z]{2})(\d+\.\d+)([a-zA-Z]+)\|";
                if (!Regex.IsMatch(input,pattern))
                {
                    continue;
                }

                var forecastMatch = Regex.Matches(input, pattern);
                foreach (Match m in forecastMatch)
                {
                    WeatherForecast forecast=new WeatherForecast(m.Groups[1].Value,double.Parse(m.Groups[2].Value),m.Groups[3].Value);
                    if (forecasts.Any(f=>f.City==forecast.City))
                    {
                        var forecastExist = forecasts.FirstOrDefault(f => f.City == forecast.City);
                        forecastExist.ChangeTemparature(forecast.AverageTemparature);
                        forecastExist.ChangeWeatherType(forecast.WheatherType);
                    }
                    else
                    {
                        forecasts.Add(forecast);
                    }
                    
                }
                
               
            }

            forecasts
                .OrderBy(f => f.AverageTemparature)
                .ToList()
                .ForEach(f => Console.WriteLine($"{f.City} => {f.AverageTemparature:f2} => {f.WheatherType}"));
        }
    }

    public class WeatherForecast
    {
        public WeatherForecast(string city, double averageTemparature, string wheatherType)
        {
            this.City = city;
            this.AverageTemparature = averageTemparature;
            this.WheatherType = wheatherType;
        }
        public string City { get; set; }
        public double AverageTemparature { get; set; }
        public string WheatherType { get; set; }

        public void ChangeTemparature(double newTemparature)
        {
            this.AverageTemparature = newTemparature;
        }

        public void ChangeWeatherType(string newWeather)
        {
            this.WheatherType = newWeather;
        }
    }
}
