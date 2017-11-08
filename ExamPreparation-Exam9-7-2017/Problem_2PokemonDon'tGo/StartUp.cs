using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem_2PokemonDon_tGo
{
    public class StartUp
    {
        public static void Main()
        {
            var distances = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            bool isRunning = true;
            int sum = 0;


            while (isRunning)
            {
                int index = int.Parse(Console.ReadLine());
                int indexForRemove;
                int changingValue;

                if (index < 0)
                {
                    changingValue = distances[0];
                    distances[0] = distances[distances.Count - 1];

                }
                else if (index >= distances.Count)
                {
                    changingValue = distances[distances.Count - 1];
                    distances[distances.Count - 1] = distances[0];
                }
                else
                {
                    indexForRemove = index;
                    changingValue = distances[index];
                    distances.RemoveAt(indexForRemove);

                }

                sum += changingValue;


                for (int i = 0; i < distances.Count; i++)
                {
                    if (distances[i] > changingValue)
                    {
                        distances[i] -= changingValue;
                    }
                    else
                    {
                        distances[i] += changingValue;
                    }

                }

                if (distances.Count == 0) isRunning = false;


            }

            Console.WriteLine(sum);

        }
    }
}
