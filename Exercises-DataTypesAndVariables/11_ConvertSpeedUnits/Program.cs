using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ConvertSpeedUnits
{
    class Program
    {
        static void Main()
        {
            float distanceInMeters = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float seconds = float.Parse(Console.ReadLine());

            float allTimeInSeconds = hours * 3600 + minutes * 60 + seconds;
            
            float metersPerSeconds = distanceInMeters / allTimeInSeconds;
            float kilometersPerHour = (distanceInMeters / 1000) / (allTimeInSeconds/3600);
            float milesPerHour = (distanceInMeters / 1609) / (allTimeInSeconds / 3600);
            Console.WriteLine($"{metersPerSeconds}");
            Console.WriteLine($"{kilometersPerHour}");
            Console.WriteLine($"{milesPerHour}");
        }
    }
}
