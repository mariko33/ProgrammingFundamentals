using System;
using System.Collections.Generic;
using System.Linq;


namespace _06_UserLogs
{
   public class Program
    {
        public static void Main()
        {
            SortedDictionary<string,Dictionary<string,int>>usersIps=new SortedDictionary<string, Dictionary<string, int>>();

            string input;
            while ((input=Console.ReadLine())!="end")
            {
                var inputArr = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
                var ipArr = inputArr[0].Split(new[] {"="}, StringSplitOptions.RemoveEmptyEntries);
                string ip = ipArr[1];

                var usernameArr = inputArr[2].Split(new[] {"="}, StringSplitOptions.RemoveEmptyEntries);
                var username = usernameArr[1];
                try
                {
                    
                    //usersIps[username][ip]=1;
                    Dictionary<string,int>curr=new Dictionary<string, int>{{ip,1}};
                    usersIps.Add(username, curr);
                }
                catch (Exception e)
                {
                    if (usersIps.ContainsKey(username))
                    {
                        if (usersIps[username].ContainsKey(ip))
                        {
                            usersIps[username][ip]++;
                        }
                        else
                        {
                            usersIps[username].Add(ip, 1);
                        }
                        
                        
                    }
                }
            }

            foreach (var pairUser in usersIps)
            {
                Console.WriteLine($"{pairUser.Key}: ");
                int count = pairUser.Value.Count;
                foreach (var pairIp in pairUser.Value) 
                {
                    Console.Write($"{pairIp.Key} => {pairIp.Value}");
                    if (count!=1)
                    {
                        Console.Write(", ");
                    }
                    else
                    {
                        Console.WriteLine(".");
                    }
                    count--;
                }
            }
        }
    }
}
