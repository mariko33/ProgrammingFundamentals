using System;

namespace CharacterStats
{
    class Program
    {
        static void Main()
        {
            string name = Console.ReadLine();
            int currentHelth = int.Parse(Console.ReadLine());
            int maxHelth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{GetResult(currentHelth,'|')}{GetResult((maxHelth-currentHelth),'.')}|");
            Console.WriteLine($"Energy: |{GetResult(currentEnergy, '|')}{GetResult((maxEnergy - currentEnergy), '.')}|");



        }


        public static string GetResult(int numberOfCondition, char pointer)
        {
            string result = "";
            for (int i = 0; i < numberOfCondition; i++)
            {
                result += pointer;
            }

            return result;

        }

    }
}



