using System;


namespace _01_CharityMarathon
{
    public class StartUp
    {
        public static void Main()
        {
            long daysLong = long.Parse(Console.ReadLine());
            long numberOfRunners = long.Parse(Console.ReadLine());
            long lapsPerRunner = long.Parse(Console.ReadLine());
            long trackLength = long.Parse(Console.ReadLine());
            long capacity = long.Parse(Console.ReadLine());
            double monneyPerKm = double.Parse(Console.ReadLine());

            if (numberOfRunners > capacity * daysLong)
            {
                numberOfRunners = capacity * daysLong;
            }

            long totalMeters = numberOfRunners * lapsPerRunner * trackLength;
            long totalKm = totalMeters / 1000;
            double price = totalKm * monneyPerKm;


            Console.WriteLine($"Money raised: {price:f2}");


        }
    }


}
