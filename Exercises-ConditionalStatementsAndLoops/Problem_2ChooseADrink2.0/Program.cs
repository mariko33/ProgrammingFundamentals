using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2ChooseADrink2._0
{
    class Program
    {
        static void Main()
        {
            string profession = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            string result;
            switch (profession)
            {

                case "Athlete":
                    result = GetResult("Athlete", quantity, (decimal)0.70);
                    break;
                case "Businessman":
                    result = GetResult("Businessman", quantity, (decimal)1.00);
                    break;
                case "Businesswoman":
                    result = GetResult("Businessman", quantity, (decimal)1.00);
                    break;
                case "SoftUni Student":
                    result = GetResult("SoftUni Student", quantity, (decimal)1.70);
                    break;
                default:
                    result = GetResult(profession, quantity, (decimal)1.20);
                    break;

            }

            Console.WriteLine(result);
        }

        public static string GetResult(string profession, int quantity, decimal price)
        {
            return $"The {profession} has to pay {quantity * price:f2}.";
        }
    }
}
