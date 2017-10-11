using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_PrimesInGivenRange
{
    class Program
    {
        static void Main()
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            List<int> primeNumbers = FindPrimesInRange(startNumber, endNumber);
            Console.WriteLine(String.Join(", ",primeNumbers));
        }

        private static bool IsPrime(int n)
        {
            if (n==0||n==1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Ceiling(Math.Sqrt(n)); ++i)
            {
                if (n % i == 0) return false;
            }
            return true;
        }
        
        private static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int>primeNumbers=new List<int>();
            
            for (int i = startNum; i <= endNum; i++)
            {
                if (IsPrime(i))
                {
                    primeNumbers.Add(i);
                }
            }
            return primeNumbers;
        }
    }
}
