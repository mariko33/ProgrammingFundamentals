using System;
using System.Collections.Generic;
using System.Linq;


namespace _09_LegendaryFarming
{
   public class StartUp
    {
        public static void Main()
        {
            Dictionary<string,int>legendaries=new Dictionary<string, int>
            {
                {"shards",0 },
                {"fragments",0 },
                {"motes",0 }
            };
            
            Dictionary<string,string>legendaryItem=new Dictionary<string, string>
            {
                {"Shadowmourne", "shards" },
                {"Valanyr", "fragments" },
                {"Dragonwrath", "motes" }
            };
            
            Dictionary<string, int>junks=new Dictionary<string, int>();

            bool isRunning = true;

            while (isRunning)
            {
                var input = Console.ReadLine().ToLower().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < input.Length-1; i++)
                {
                    if (legendaries.ContainsKey(input[i + 1]))
                    {
                        if (legendaries[input[i+1]]+int.Parse(input[i])<=250)
                        {
                            legendaries[input[i + 1]] += int.Parse(input[i]);
                        }
                        else
                        {
                            AddToDictionary(input[i + 1], (int.Parse(input[i]) - (250 - legendaries[input[i + 1]])), junks);
                            legendaries[input[i + 1]] += (250 - legendaries[input[i + 1]]);
                            
                        }
                        
                        
                    }
                    else
                    {
                        
                        AddToDictionary(input[i+1],int.Parse(input[i]),junks);
                        
                    }

                    if (legendaries.Values.Any(e => e >= 250))
                    {
                        isRunning = false;
                        break;
                    }
                    i = i + 1;
                }

                if (isRunning==false)
                {
                    break;
                }

            }

            string resultKey = legendaries.Keys.First(e => legendaries[e] == 250);
            if (junks.ContainsKey(resultKey))
            {
                legendaries[resultKey] = junks[resultKey];
                junks.Remove(resultKey);
            }
            else
            {
                legendaries[resultKey]=0;
            }
            
            var legendariesSort = legendaries.OrderByDescending(e => e.Value).ThenBy(e=>e.Key);

            Console.Write($"{legendaryItem.Keys.First(k => legendaryItem[k] == resultKey)} obtained!{Environment.NewLine}");
            
            foreach (var pairLeg in legendariesSort)
            {
                
                    Console.WriteLine($"{pairLeg.Key}: {pairLeg.Value}");
                
            }
            foreach (var pairJunk in junks.OrderBy(e=>e.Key))
            {
                Console.WriteLine($"{pairJunk.Key}: {pairJunk.Value}");
            }
        }

        public static void AddToDictionary(string keyDic, int valueDic,Dictionary<string,int>collection)
        {
            if (!collection.ContainsKey(keyDic))
            {
                collection.Add(keyDic,valueDic);
            }
            else
            {
                collection[keyDic] += valueDic;
            }
        }

        public static string StartWithUpper(string input)
        {
            return char.ToUpper(input[0]) + input.Substring(1);
        }
    }
}
