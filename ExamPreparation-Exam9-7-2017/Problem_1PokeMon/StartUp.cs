using System;


namespace Problem_1PokeMon
{
    public class StartUp
    {
        public static void Main()
        {
            int power = int.Parse(Console.ReadLine());
            int distance= int.Parse(Console.ReadLine());
            int exhaustionFactor= int.Parse(Console.ReadLine());

            int originalPower = power;

            int targetSucceeded = 0;

            while (power>=distance)
            {
                if (exhaustionFactor!=0&&power==originalPower*0.5)
                {
                    power /= exhaustionFactor;
                    if (power<distance)
                    {
                        continue;
                    }
                }
                power -= distance;
                targetSucceeded++;

            }

            Console.WriteLine(power);
            Console.WriteLine(targetSucceeded);
        }
    }
}
