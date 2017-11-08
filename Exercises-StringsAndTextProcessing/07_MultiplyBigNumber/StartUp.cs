using System;
using System.Linq;


namespace _07_MultiplyBigNumber
{
    public class StartUp
    {
       public static void Main(string[] args)
        {
            string first = Console.ReadLine();
            string second = Console.ReadLine();

            int maxLength = Math.Max(first.Length, second.Length);



            var firstArr = first.Select(d => int.Parse(d.ToString())).ToArray();
            var secondArr = int.Parse(second);


            int reminder = 0;

            string result = String.Empty;
            if (secondArr == 0) { result += 0; }

            for (int i = maxLength - 1; i >= 0; i--)
            {
                int res = (firstArr[i] * secondArr) + reminder;

                if (res > 9)
                {
                    reminder = res / 10;
                }
                else
                {
                    reminder = 0;
                }

                if (i == 0) { result = res + result; }
                else { result = res % 10 + result; }


            }

            if (result.StartsWith("0"))
            {
                result = result.TrimStart('0');
                if (result == "") { result += 0; }
            }
            Console.WriteLine(result);
        }
    }
}
