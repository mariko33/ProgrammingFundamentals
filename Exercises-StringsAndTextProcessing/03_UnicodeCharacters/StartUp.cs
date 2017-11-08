using System;
using System.Linq;


namespace _03_UnicodeCharacters
{
    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            
            string result=String.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                result += GetCharInUnicod(input[i]);
            }

            Console.WriteLine(result);

        }

        public static string GetCharInUnicod(char a)
        {
            return @"\u" + ((int) a).ToString("x4");
        }
    }
}
