using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4Hotel
{
    class Program
    {
        static void Main()
        {
            string mounth = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());
            decimal studioPricePerNight = 0;
            decimal doublePricePerNight = 0;
            decimal suitePricePerNight = 0;
            switch (mounth)
            {
                case "May":
                    studioPricePerNight = 50;
                    doublePricePerNight = 65;
                    suitePricePerNight = 75;
                    break;
                case "October":
                    studioPricePerNight = 50;
                    doublePricePerNight = 65;
                    suitePricePerNight = 75;
                    break;
                case "June":
                    studioPricePerNight = 60;
                    doublePricePerNight = 72;
                    suitePricePerNight = 82;
                    break;
                case "September":
                    studioPricePerNight = 60;
                    doublePricePerNight = 72;
                    suitePricePerNight = 82;
                    break;
                case "July":
                    studioPricePerNight = 68;
                    doublePricePerNight = 77;
                    suitePricePerNight = 89;
                    break;
                case "August":
                    studioPricePerNight = 68;
                    doublePricePerNight = 77;
                    suitePricePerNight = 89;
                    break;
                case "December":
                    studioPricePerNight = 68;
                    doublePricePerNight = 77;
                    suitePricePerNight = 89;
                    break;
            }

            
            
            if ((mounth== "May"||mounth== "October")&&nightCount>7)
            {
                studioPricePerNight -= studioPricePerNight * (decimal) 0.05;
            }

            if ((mounth== "June"||mounth== "September")&&nightCount>14)
            {
                doublePricePerNight -= doublePricePerNight * (decimal) 0.1;
            }


            if ((mounth == "July" || mounth == "August"||mounth== "December") && nightCount > 14)
            {
                suitePricePerNight -= suitePricePerNight * (decimal)0.15;
            }
            
            
            
            StringBuilder result=new StringBuilder();
            if ((mounth == "September" || mounth == "October") && nightCount > 7)
            {
               
                result.AppendLine($"Studio: {studioPricePerNight * (nightCount-1):f2} lv.");
            }

            else
            {
                result.AppendLine($"Studio: {studioPricePerNight * nightCount:f2} lv.");
            }
           
            result.AppendLine($"Double: {doublePricePerNight * nightCount:f2} lv.");
            result.AppendLine($"Suite: {suitePricePerNight * nightCount:f2} lv.");
            Console.WriteLine(result.ToString());

        }
    }
}
