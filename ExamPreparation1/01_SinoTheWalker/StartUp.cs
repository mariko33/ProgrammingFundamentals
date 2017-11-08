using System;
using System.Globalization;


namespace _01_SinoTheWalker
{
    public class StartUp
    {
        public static void Main()
        {
            DateTime leavingHour = DateTime.ParseExact(Console.ReadLine(), "HH:mm:ss", CultureInfo.InvariantCulture);

            int numberOfSteps = int.Parse(Console.ReadLine()) % 86400;         //84600 seconds for 24 hours
            int secondsForStep = int.Parse(Console.ReadLine()) % 86400;       //84600 seconds for 24 hours

            var timeForLeavingSec = numberOfSteps * secondsForStep;
            int minutes = (timeForLeavingSec / 60);
            int hours = minutes / 60;
            minutes = minutes % 60;
            int seconds = (timeForLeavingSec % 60);

            DateTime newTime = leavingHour.AddHours(hours).AddMinutes(minutes).AddSeconds(seconds);


            Console.WriteLine($"Time Arrival: {newTime.ToString("HH:mm:ss")}");



        }
    }
}
