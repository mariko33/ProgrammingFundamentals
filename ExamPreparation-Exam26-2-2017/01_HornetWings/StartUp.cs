using System;

namespace _01_HornetWings
{
    public class StartUp
    {
        public static void Main()
        {
            long wingFlaps = long.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            long endurance = long.Parse(Console.ReadLine());

            double metersTraveled = wingFlaps / 1000 * distance;
            long secondPassed = wingFlaps / 100 + (wingFlaps / endurance * 5);

            Console.WriteLine($"{metersTraveled:f2} m.");
            Console.WriteLine($"{secondPassed} s.");
        }
    }
}
