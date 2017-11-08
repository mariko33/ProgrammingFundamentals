using System;


namespace _01_TheaThePhotographer
{
    public class StartUp
    {
        public static void Main()
        {
            long totalPictureN = long.Parse(Console.ReadLine());
            long filteredTimeFT = long.Parse(Console.ReadLine());
            double percentageFilteredFactorFF= double.Parse(Console.ReadLine());
            long uploadTimeUT = long.Parse(Console.ReadLine());

            long filteredPicture =(long) Math.Ceiling(totalPictureN*(percentageFilteredFactorFF/100));
            long totalTime = totalPictureN * filteredTimeFT + filteredPicture * uploadTimeUT;

            long days = totalTime / 86400;                          //seconds for day
            long hours = totalTime % 86400/3600;
            long minutes = totalTime % 86400 % 3600/60;
            long seconds = totalTime % 86400 % 3600 % 60;

            Console.WriteLine($"{days}:{hours:d2}:{minutes:d2}:{seconds:d2}");





        }
    }
}
