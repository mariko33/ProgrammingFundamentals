using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_ComparingFloats
{
    class Program
    {
        static void Main()
        {
            double firstInput = double.Parse(Console.ReadLine());
            double secondInput = double.Parse(Console.ReadLine());
            double minNumber = Math.Min(firstInput, secondInput);
            double maxNumber = Math.Max(firstInput, secondInput);
            bool isEqual = maxNumber - minNumber<= 0.000001;
            Console.WriteLine(isEqual);
        }
    }
}
