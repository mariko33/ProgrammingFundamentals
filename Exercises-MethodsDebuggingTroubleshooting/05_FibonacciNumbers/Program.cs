using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_FibonacciNumbers
{
    class Program
    {
        static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciSeries(input));
        }

        public static int FibonacciSeries(int n)
        {
            if (n == 0) return 1; //To return the first Fibonacci number   
            if (n == 1) return 1; //To return the second Fibonacci number 
            
           
            return FibonacciSeries(n - 1) + FibonacciSeries(n - 2);
        }
    }
}
