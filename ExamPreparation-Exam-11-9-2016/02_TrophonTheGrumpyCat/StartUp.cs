using System;
using System.Collections.Generic;
using System.Linq;


namespace _02_TrophonTheGrumpyCat
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string,long>results=new Dictionary<string, long>{{"Left",0},{"Right",0}};

            var prices = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            int indexEntryPoint = int.Parse(Console.ReadLine());
            string typeItem = Console.ReadLine();
            string typePrice = Console.ReadLine();
            

            var leftList = prices.Take(indexEntryPoint).ToList();
            var rightList = prices.Skip(indexEntryPoint + 1).ToList();

            
            long sumLeft=Sum(leftList, prices[indexEntryPoint], typeItem, typePrice);
            results["Left"] += sumLeft;

            long sumRight = Sum(rightList, prices[indexEntryPoint], typeItem, typePrice);
            results["Right"] += sumRight;
            if (results["Left"]>=results["Right"])
            {
                Console.WriteLine($"Left - {results["Left"]}");
            }
            else
            {
                Console.WriteLine($"Right - {results["Right"]}");
            }

        }


        public static long Sum(List<long>prices, long entryPoin, string typeItem, string typePrice)
        {
            long sum = 0;
            for (int i = 0; i < prices.Count; i++)
            {
                switch (typePrice)
                {
                    case "positive":
                        if (typeItem=="cheap")
                        {
                            if (prices[i]>0&&prices[i]<entryPoin)
                            {
                                sum += prices[i];
                            }
                        }
                        else
                        {
                            if (prices[i]>0&&prices[i]>=entryPoin)
                            {
                                sum += prices[i];
                            }
                        }
                        break;
                    case "negative":
                        if (typeItem == "cheap")
                        {
                            if (prices[i] < 0 && prices[i] < entryPoin)
                            {
                                sum += prices[i];
                            }
                        }
                        else
                        {
                            if (prices[i] < 0 && prices[i] >= entryPoin)
                            {
                                sum += prices[i];
                            }
                        }
                        break;
                    case "all":
                        if (typeItem == "cheap")
                        {
                            if ( prices[i] < entryPoin)
                            {
                                sum += prices[i];
                            }
                        }
                        else
                        {
                            if ( prices[i] >= entryPoin)
                            {
                                sum += prices[i];
                            }
                        }
                        break;
                }
                
            }

            return sum;
        }
    }
}
