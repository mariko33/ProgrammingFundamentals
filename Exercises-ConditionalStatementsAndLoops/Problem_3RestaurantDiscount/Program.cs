using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3RestaurantDiscount
{
    class Program
    {
        static void Main()
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            decimal packagePrice=0;
            double discount=0;
            string suitableHall;
            decimal pricePerPerson=0;
            switch (package)
            {
                case "Normal":
                    discount = 0.05;
                    packagePrice = 500;
                    break;
                case "Gold":
                    discount = 0.1;
                    packagePrice = 750;
                    break;
                case "Platinum":
                    discount = 0.15;
                    packagePrice = 1000;
                    break;
            }

            if (groupSize<=50)
            {
                suitableHall = "Small Hall";
                pricePerPerson = ((2500 + packagePrice)-(2500 + packagePrice) * (decimal) discount) / groupSize;
                Console.WriteLine($"We can offer you the {suitableHall}{Environment.NewLine}The price per person is {pricePerPerson:f2}$");

            }
            if (groupSize >= 50 && groupSize <=100)
            {
                suitableHall = "Terrace";
                pricePerPerson = ((5000 + packagePrice)-(5000 + packagePrice) * (decimal)discount) / groupSize;
                Console.WriteLine($"We can offer you the {suitableHall}{Environment.NewLine}The price per person is {pricePerPerson:f2}$");
            }
            if (groupSize >= 100 && groupSize <=120)
            {
                suitableHall = "Great Hall";
                pricePerPerson = ((7500 + packagePrice)-(7500 + packagePrice) * (decimal)discount )/ groupSize;
                Console.WriteLine($"We can offer you the {suitableHall}{Environment.NewLine}The price per person is {pricePerPerson:f2}$");
            }
            else if (groupSize>120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            

        }
    }
}
