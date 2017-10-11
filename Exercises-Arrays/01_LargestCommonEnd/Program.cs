using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LargestCommonEnd
{
    class Program
    {
        static void Main()
        {
            string[] arr1 = Console.ReadLine().Split(' ');
            string[] arr2 = Console.ReadLine().Split(' ');

            if (arr1.Length<arr2.Length)
            {
                PrintCommonEnd(arr1,arr2);
            }
            else
            {
                PrintCommonEnd(arr2,arr1);
            }

        }

        static void PrintCommonEnd(string[] arr1, string[] arr2)
        {
            int leftComman = 0;
            int rightComman = 0;
            
            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i]==arr2[i])
                {
                    leftComman++;
                }
            }

            int count = 1;
            for (int i = arr1.Length-1; i >= 0; i--)
            {
                if (arr1[i]==arr2[arr2.Length-count])
                {
                    rightComman++;
                }
                count++;
            }

           
            if (leftComman>=rightComman)
            {
                Console.WriteLine(leftComman);
            }
            else
            {
                Console.WriteLine(rightComman);
            }
        }
    }
}
