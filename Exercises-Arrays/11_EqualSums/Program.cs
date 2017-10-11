using System;
using System.Linq;


namespace _11_EqualSums
{
    class Program
    {
        static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool isSumEqual=false;
            
            for (int i = 0; i < arr.Length; i++)
            {
                int[] arrLeft = arr.Take(i).ToArray();
                int[] arrRight = arr.Skip(i+1).Take(arr.Length - i).ToArray();
                if (arrLeft.Sum()==arrRight.Sum())
                {
                    isSumEqual = true;
                    Console.WriteLine(i);
                    
                }
                
            }

            if (!isSumEqual)
            {
                Console.WriteLine("no");
            }




        }
    }
}
