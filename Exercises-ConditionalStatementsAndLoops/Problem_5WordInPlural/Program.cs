using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_5WordInPlural
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string result;

            if (input.EndsWith("y"))
            {
                string inputRemove=input.Remove(input.Length - 1);
                result = inputRemove + "ies";
            }
            else if ((input.EndsWith("o") || input.EndsWith("ch") || input.EndsWith("s") || input.EndsWith("sh") || input.EndsWith("x") || input.EndsWith("z")))
            {
                result = input + "es";
            }
            else
            {
                result = input + "s";
            }
            
            Console.WriteLine(result);
        }
    }
}
