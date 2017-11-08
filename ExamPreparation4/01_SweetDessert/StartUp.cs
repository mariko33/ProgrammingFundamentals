using System;
using System.CodeDom;

namespace _01_SweetDessert
{
    public class StartUp
    {
        public static void Main()
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            int guestNumbers = int.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggPrice = decimal.Parse(Console.ReadLine());
            decimal berriesPrice = decimal.Parse(Console.ReadLine());

            int setsOfGuests;
            if (guestNumbers % 6 == 0)
            {
                setsOfGuests = (guestNumbers / 6);
            }
            else
            {
                setsOfGuests = (guestNumbers / 6) + 1;
            }

            decimal totalPrice = setsOfGuests * (2 * bananaPrice + 4 * eggPrice + (decimal)0.2 * berriesPrice);

            if (cash >= totalPrice)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(totalPrice - cash):f2}lv more.");
            }
        }
    }
}
