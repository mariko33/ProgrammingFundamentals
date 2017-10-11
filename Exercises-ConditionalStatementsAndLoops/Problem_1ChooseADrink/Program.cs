using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1ChooseADrink
{
    class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            string result;
            switch (profession)
            {
                case "Athlete":
                    result = "Water";
                    break;
                case "Businessman":
                    result = "Coffee";
                    break;
                case "Businesswoman":
                    result = "Coffee";
                    break;
                case "SoftUni Student":
                    result = "Beer";
                    break;
                default:
                    result = "Tea";
                    break;

            }

            Console.WriteLine(result);
        }
    }
}
