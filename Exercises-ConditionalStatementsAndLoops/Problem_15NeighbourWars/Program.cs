using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_15NeighbourWars
{
    class Program
    {
        static void Main()
        {
            int peshoDamage = int.Parse(Console.ReadLine());
            int goshoDamage = int.Parse(Console.ReadLine());
            int peshoPoints = 100;
            int goshoPoints = 100;


            for (int round = 1; ; round++)
            {
                if (round % 2 == 0)
                {
                    peshoPoints -= goshoDamage;
                    if (peshoPoints > 0)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshoPoints} health.");
                    }

                }
                else
                {
                    goshoPoints -= peshoDamage;

                    if (goshoPoints > 0)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshoPoints} health.");
                    }

                }

                if (peshoPoints <= 0)
                {
                    Console.WriteLine($"Gosho won in {round}th round.");
                    return;
                }

                if (goshoPoints <= 0)
                {
                    Console.WriteLine($"Pesho won in {round}th round.");
                    return;
                }

                if (round % 3 == 0)
                {
                    peshoPoints += 10;
                    goshoPoints += 10;
                }
            }

        }
    }
}
