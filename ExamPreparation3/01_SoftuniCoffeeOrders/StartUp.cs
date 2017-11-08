using System;
using System.Globalization;

namespace _01_SoftuniCoffeeOrders
{
    public class StartUp
    {
        public static void Main()
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            decimal totalPrice = 0;

            for (int i = 1; i <= numberOfOrders; i++)
            {
                decimal pricePerCapsule = decimal.Parse(Console.ReadLine());
                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                long capsuleCount = long.Parse(Console.ReadLine());
                int days = DateTime.DaysInMonth(orderDate.Year, orderDate.Month);
                decimal price = (days * pricePerCapsule) * capsuleCount;
                totalPrice += price;
                Console.WriteLine($"The price for the coffee is: ${price:f2}");

            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }

    }
}
