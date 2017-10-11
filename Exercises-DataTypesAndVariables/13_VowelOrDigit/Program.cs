using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_VowelOrDigit
{
    class Program
    //A, E, I, O, U
    {
        static void Main()
        {
            string input = Console.ReadLine();
            if (input.All(char.IsDigit))
            {
                Console.WriteLine("digit");
            }

            else if(input=="a"||input=="e"||input=="i"||input=="o"||input=="u")
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
