using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_TheaThePhotographer
{
    class Program
    {
        static void Main()
        {
            double countOfAlPictures = double.Parse(Console.ReadLine());
            int filterTimeSeconds = int.Parse(Console.ReadLine());
            double percentageOffilteredPictures = double.Parse(Console.ReadLine());
            int uploadTimeSeconds = int.Parse(Console.ReadLine());

            double filteredPictures = Math.Ceiling(countOfAlPictures * percentageOffilteredPictures / 100);

            double totalTime = (countOfAlPictures * filterTimeSeconds) + (filteredPictures * uploadTimeSeconds);

            
            long days = (long)totalTime/86400;
            
            long hours = ((long)totalTime % 86400)/3600;
            long minutes = (((long) totalTime % 86400) % 3600) / 60;
            long seconds = (((long) totalTime % 86400) % 3600) % 60;

            Console.WriteLine($"{days}:{hours:D2}:{minutes:D2}:{seconds:D2}");

        }
    }
}
