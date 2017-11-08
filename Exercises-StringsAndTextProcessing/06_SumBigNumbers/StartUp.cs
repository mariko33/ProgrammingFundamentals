using System;
using System.Linq;


namespace _06_SumBigNumbers
{
   public class StartUp
    {
        public static void Main()
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            int maxLength = Math.Max(first.Length, second.Length);

            first = first.PadLeft(maxLength + 1, '0');
            second = second.PadLeft(maxLength + 1, '0');

            var firstArr = first.Select(d=>int.Parse(d.ToString())).ToArray();
            var secondArr = second.Select(d => int.Parse(d.ToString())).ToArray();

            
            int reminder = 0;

            string result = String.Empty;

            for (int i = maxLength; i >= 0; i--)
            {
                int res = (firstArr[i] + secondArr[i]+reminder);

                if (res>9)
                {
                    reminder = 1;
                }
                else
                {
                    reminder = 0;
                }
                
                result = res%10 + result;

            }

            if (result.StartsWith("0"))
            {
                result = result.TrimStart('0');
            }
            Console.WriteLine(result);
        }
    }
}
