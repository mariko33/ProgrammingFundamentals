using System;
using System.Globalization;
using System.Linq;


namespace _01_CountWorkingDays
{
    class StartUp
    {
        static void Main()
        {
            string inputDateStart = Console.ReadLine();
            string inputDataEnd = Console.ReadLine();
            string formatData = "d-MM-yyyy";

            DateTime startDate = DateTime.ParseExact(inputDateStart, formatData, CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(inputDataEnd, formatData, CultureInfo.InvariantCulture);

            DateTime[] nonWorkingDays = new DateTime[]
            {
                new DateTime(2016,01,01),
                new DateTime(2016,03,03),
                new DateTime(2016,05,01),
                new DateTime(2016,05,06),
                new DateTime(2016,05,24),
                new DateTime(2016,09,06),
                new DateTime(2016,09,22),
                new DateTime(2016,11,01),
                new DateTime(2016,12,24),
                new DateTime(2016,12,25),
                new DateTime(2016,12,26),

            };

            int counterWorkingDays = 0;

            DateTime current = startDate;

            while (current <= endDate)
            {
                string dayOfWeek = current.DayOfWeek.ToString();
                if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
                {
                    current = current.AddDays(1);
                    continue;
                }

                if (nonWorkingDays.Any(e => e.Day == current.Day&&e.Month==current.Month))
                {
                    current = current.AddDays(1);
                    continue;
                }

                counterWorkingDays++;

                current = current.AddDays(1);
            }


            Console.WriteLine(counterWorkingDays);
        }
    }
}
