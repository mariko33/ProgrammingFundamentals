using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _12_MasterNumber
{
    class Program
    {
        static void Main()
        {
            List<int>masterList=new List<int>();

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i <= input; i++)
            {
                if (IsMasterNumber(i))
                {
                    masterList.Add(i);
                }
            }
            
            masterList.ForEach(m=>Console.WriteLine(m));
                

        }

        static bool IsSymmetric(string number)
        {
            for (int i = 0; i <= (number.Length)/2; i++)
            {
                if (number[i]!=number[number.Length-1-i])
                {
                    return false;
                }
            }
            return true;
        }

        static bool IsSumDivisibleToSeven(string input)
        {
            int sum = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                int current = (int)Char.GetNumericValue(input[i]);
                sum += current;
            }

            if (sum%7==0)
            {
                return true;
            }

            return false;
        }

        static bool IsAtLeastAEvenDigit(string input)
        {
            int evenCount = 0;
            
            for (int i = 0; i < input.Length-1; i++)
            {
                if ((int)Char.GetNumericValue(input[i])%2==0)
                {
                    evenCount++;
                }
            }

            if (evenCount==0)
            {
                return false;
            }

            return true;
        }

        static bool IsMasterNumber(int number)
        {
            string input = number.ToString();
            if (IsSymmetric(input)&&IsSumDivisibleToSeven(input)&&IsAtLeastAEvenDigit(input))
            {
                return true;
            }

            return false;
        }
    }
}
