using System;
using System.Linq;

namespace _05_MagicExchangeableWords
{
   public class StartUp
    {
       public static void Main(string[] args)
       {
           var input = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
           var firstArr = input[0].Distinct().ToArray();
           var secondArr = input[1].Distinct().ToArray();

           if (firstArr.Length==secondArr.Length)
           {
               Console.WriteLine("true");
           }
           else
           {
               Console.WriteLine("false");
           }
       }
    }
}
