using System;
using System.Collections.Generic;
using System.Linq;


public class StartUp
{
    public static void Main()
    {
        List<DataSet> dataSets = new List<DataSet>();
        List<DataSet> cacheSets = new List<DataSet>();

        string input;
        while ((input = Console.ReadLine()) != "thetinggoesskrra")
        {
            var inputArr = input.Split(new[] { " ", "{", "}", "|", "-", ">" }, StringSplitOptions.RemoveEmptyEntries);

            if (inputArr.Length == 1)
            {
                if (!dataSets.Any(s => s.Name == inputArr[0]))
                {
                    dataSets.Add(new DataSet(inputArr[0]));
                    if (cacheSets.Any(s => s.Name == inputArr[0]))
                    {
                        var casheS = cacheSets.FirstOrDefault(s => s.Name == inputArr[0]);
                        dataSets.FirstOrDefault(s => s.Name == inputArr[0]).KeySize = casheS.KeySize;
                    }
                }
            }
            else
            {
                string key = inputArr[0];
                long size = long.Parse(inputArr[1]);
                string setName = inputArr[2];

                if (!dataSets.Any(s => s.Name == setName))
                {
                    if (cacheSets.Any(s => s.Name == setName))
                    {
                        var currCache = cacheSets.FirstOrDefault(s => s.Name == setName);
                        if (currCache.KeySize.ContainsKey(key))
                        {
                            currCache.KeySize[key] += size;
                        }
                        else
                        {
                            currCache.KeySize.Add(key, size);
                        }

                    }
                    else
                    {
                        cacheSets.Add(new DataSet(setName));
                        cacheSets.FirstOrDefault(s => s.Name == setName).KeySize.Add(key, size);
                    }

                }
                else
                {
                    var currSet = dataSets.FirstOrDefault(s => s.Name == setName);
                    if (currSet.KeySize.ContainsKey(key))
                    {
                        currSet.KeySize[key] += size;
                    }
                    else
                    {
                        currSet.KeySize.Add(key, size);
                    }
                }
            }
        }

        if (dataSets.Count > 0)
        {
            var res = dataSets
                .OrderByDescending(s => s.KeySize.Sum(kv => kv.Value))
                .First();
            Console.WriteLine($"Data Set: {res.Name}, Total Size: {res.KeySize.Sum(kv => kv.Value)}");
            foreach (var k in res.KeySize.Keys)
            {
                Console.WriteLine($"$.{k}");
            }
        }



    }
}

public class DataSet
{
    public DataSet(string name)
    {
        this.Name = name;
        this.KeySize = new Dictionary<string, long>();
    }
    public string Name { get; set; }
    public Dictionary<string, long> KeySize { get; set; }
}

