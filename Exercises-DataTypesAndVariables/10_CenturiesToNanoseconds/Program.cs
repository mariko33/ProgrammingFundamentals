using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CenturiesToNanoseconds
{
    class Program
    {
        static void Main()
        {
            int centuries = int.Parse(Console.ReadLine());


            int years = centuries * 100;


            int days = (int)(years * 365.2422);


            int hours = 24 * days;


            ulong minutes = (ulong)(60 * hours);

            ulong seconds = (60 * minutes);

            ulong milliseconds = 1000 * seconds;

            ulong microseconds = 1000 * milliseconds;

            string nanoseconds = $"{microseconds}000";

            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
        }
    }
}
