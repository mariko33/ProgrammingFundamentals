using System;

using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            int numberOfSites = int.Parse(Console.ReadLine());
            int securityToken = int.Parse(Console.ReadLine());

            decimal sitesLoss = 0;

            for (int i = 0; i < numberOfSites; i++)
            {
                var inputArr = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                if (inputArr.Length > 3)
                {
                    continue;
                }

                Console.WriteLine(inputArr[0]);

                sitesLoss += long.Parse(inputArr[1]) * decimal.Parse(inputArr[2]);

            }

            BigInteger finalSecurityToken = securityToken;
            for (int i = 1; i < numberOfSites; i++)
            {
                finalSecurityToken *= securityToken;
            }

            Console.WriteLine($"Total Loss: {sitesLoss:f20}");
            Console.WriteLine($"Security Token: {finalSecurityToken}");

        }
    }

