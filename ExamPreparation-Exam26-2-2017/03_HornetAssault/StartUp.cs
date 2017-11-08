using System;
using System.Collections.Generic;
using System.Linq;


namespace _03_HornetAssault
{
    public class StartUp
    {
        public static void Main()
        {
            var beehives = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            var hornets = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();

            long sumHornetsPower = hornets.Sum();

            for (int i = 0; i < beehives.Count; i++)
            {
                if (beehives[i] >= sumHornetsPower)
                {
                    beehives[i] -= sumHornetsPower;
                    if (sumHornetsPower > 0)
                    {
                        sumHornetsPower -= hornets[0];

                        hornets.RemoveAt(0);
                    }
                }
                else
                {
                    beehives[i] = 0;
                }

            }
            if (beehives.Any(b => b != 0))
            {
                Console.WriteLine(string.Join(" ", beehives.Where(b => b != 0)));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornets.Where(h => h != 0)));
            }

        }


    }
}
