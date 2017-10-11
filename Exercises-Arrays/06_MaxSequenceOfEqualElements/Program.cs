using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int start = 0;
            int lengthCurrent = 1;

            int bestNumber = 0;
            int count = 1;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]==arr[i-1])
                {
                    start = arr[i];
                    lengthCurrent++;
                    
                    if (count < lengthCurrent)
                    {
                        count = lengthCurrent;
                        bestNumber = start;
                        
                    }

                }
                else
                {
                    //start = 0;
                    lengthCurrent = 1;

                }
                
            }

            for (int i = 0; i < count; i++)
            {
                Console.Write(bestNumber + " ");
            }

           
        }
    }
}
