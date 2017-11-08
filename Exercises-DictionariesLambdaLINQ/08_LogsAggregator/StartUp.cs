using System;
using System.Collections.Generic;
using System.Linq;


namespace _08_LogsAggregator
{
   public class StartUp
    {
        public static void Main()
        {
            Dictionary<string,Dictionary<string,int>>users=new Dictionary<string, Dictionary<string, int>>();
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    users.Add(input[1],new Dictionary<string, int>{{input[0],int.Parse(input[2])}});
                }
                catch (Exception e)
                {
                    if (users.ContainsKey(input[1]))
                    {
                        if (users[input[1]].ContainsKey(input[0]))
                        {
                            users[input[1]][input[0]] += int.Parse(input[2]);
                        }
                        else
                        {
                            users[input[1]].Add(input[0],int.Parse(input[2]));
                        }
                    }
                }
            }
            
            foreach (var pairUser in users.OrderBy(u=>u.Key))
            {
                Console.Write($"{pairUser.Key}: {pairUser.Value.Sum(e => e.Value)} ["); //{String.Join(", ",pairUser.Value.OrderBy(v=>v.Key))}]");
                int count = pairUser.Value.Count;
                foreach (var pairIp in pairUser.Value.OrderBy(v => v.Key))
                {
                    if (count!=1)
                    {
                        Console.Write($"{pairIp.Key}, ");
                    }
                    else
                    {
                        Console.Write($"{pairIp.Key}]");
                    }

                    count--;
                }
                Console.WriteLine();
                
            }
        }
    }
}
