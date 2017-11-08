using System;
using System.Collections.Generic;
using System.Linq;


namespace _07_PopulationCounter
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> countries = new Dictionary<string, Dictionary<string, long>>();

            string input;
            while ((input = Console.ReadLine()) != "report")
            {
                var inputArr = input.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    countries.Add(inputArr[1], new Dictionary<string, long> { { inputArr[0], long.Parse(inputArr[2]) } });
                }
                catch (Exception e)
                {
                    if (countries.ContainsKey(inputArr[1]))
                    {
                        countries[inputArr[1]].Add(inputArr[0], int.Parse(inputArr[2]));
                    }
                }
            }

            var sortetCountries = countries.OrderByDescending(c => c.Value.Sum(e => e.Value));
            foreach (var pairCountry in sortetCountries)
            {
                Console.WriteLine($"{pairCountry.Key} (total population: {pairCountry.Value.Sum(e => e.Value)})");
                
                foreach (var pairDic in pairCountry.Value.OrderByDescending(e=>e.Value))
                {
                    Console.WriteLine($"=>{pairDic.Key}: {pairDic.Value}");
                }
            }
        }
    }
}
