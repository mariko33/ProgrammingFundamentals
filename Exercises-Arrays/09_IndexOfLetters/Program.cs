using System;

namespace _09_IndexOfLetters
{
   public class Program
    {
       public static void Main()
       {
           string input = Console.ReadLine();
           for (int i = 0; i < input.Length; i++)
           {
               Console.WriteLine($"{input[i]} -> {(int)input[i]-97}");
           }
       }
    }
}
