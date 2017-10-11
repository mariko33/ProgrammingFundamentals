using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_CompareCharArrays
{
    class Program
    {
        static void Main()
        {
            char[] arr1 =Console.ReadLine()
                .Split(' ')
                .Select(char.Parse)
                .ToArray();
            
            char[] arr2 = Console.ReadLine()
                    .Split(' ')
                    .Select(char.Parse)
                    .ToArray();
                
            
            int minLength = Math.Min(arr1.Length, arr2.Length);

            string result1="";
            string result2 = "";
            int count = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (arr1[i]<arr2[i])
                {
                    result1 = new string(arr1);
                    result2=new string(arr2);
                }
                else
                {
                    result1 = new string(arr2);
                    result2=new string(arr1);
                }
                if (arr1[i]==arr2[i])
                {
                    count++;
                }
            }

            if (count==minLength)
            {
                if (arr1.Length==minLength)
                {
                    result1 = new string(arr1);
                    result2=new string(arr2);
                }
                else
                {
                    result1 = new string(arr2);
                    result2=new string(arr1);
                }


                
            }

            Console.WriteLine(result1);
            Console.WriteLine(result2);


        }

       
    }
}
