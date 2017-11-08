using System;
using System.Collections.Generic;
using System.Linq;


namespace _03_AMinerTask
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string,int>minerResources=new Dictionary<string, int>();
            List<string>curr=new List<string>();
            string input;
            while ((input=Console.ReadLine())!="stop")
            {
                curr.Add(input);
            }

            for (int i = 0; i < curr.Count-1; i++)
            {
                try
                {
                    minerResources.Add(curr[i], int.Parse(curr[i+1]));
                }
                catch (Exception e)
                {
                    minerResources[curr[i]] += int.Parse(curr[i + 1]);
                }
                i = i + 1;
            }
            foreach (var pair in minerResources)
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
