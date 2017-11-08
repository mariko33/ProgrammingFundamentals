using System;
using System.Collections.Generic;
using System.Linq;


namespace _10_SerbianUnleashed
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, Dictionary<string, long>> towns = new Dictionary<string, Dictionary<string, long>>();

            string input;

            while ((input = Console.ReadLine()) != "End")
            {
                int count = 0;
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == '@')
                    {
                        count++;
                    }
                }


                if (count == 1)
                {

                    var currInput = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                    // Very important test!!!
                    if (!currInput.Any(e => e.StartsWith("@")))
                    {
                        continue;
                    }
                    

                    var inputArr = input.Split(new[] { "@" }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    
                    var inputName = inputArr[0].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    
                    var inputVenuePrice = inputArr[1].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    
                    // 1.
                    if (inputName.Length <= 3 && inputName.Length >= 1 && inputVenuePrice.Length <= 5 && inputVenuePrice.Length >= 3)
                    {
                        string name = "";

                        name += String.Join(" ", inputName);
                        
                        // no need
                        if (name.Any(Char.IsDigit))
                        {
                            name = "";
                            continue;
                        }
                        
                        // very important
                        int ticketCount;
                        int ticketPrice;
                        try
                        {
                            ticketCount = int.Parse(inputVenuePrice[inputVenuePrice.Length - 2]);
                            ticketPrice = int.Parse(inputVenuePrice[inputVenuePrice.Length - 1]);
                        }

                        catch
                        {
                            continue;
                        }

                        long amountMoney = (long) ticketCount * ticketPrice;

                        string venue = "";
                        for (int i = 0; i < inputVenuePrice.Length - 2; i++)
                        {
                            venue += inputVenuePrice[i] + " ";


                        }
                         venue = venue.TrimEnd();
                        
                        // no need
                        if (venue.Any(Char.IsDigit))
                        {
                            venue = "";
                            continue;
                        }


                        if (!towns.ContainsKey(venue))
                        {

                            towns.Add(venue, new Dictionary<string, long> { { name, amountMoney } });
                        }
                        else
                        {
                            if (!towns[venue].ContainsKey(name))
                            {
                                towns[venue].Add(name, (amountMoney));
                            }
                            else
                            {
                                towns[venue][name] += (amountMoney);
                            }

                        }


                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    continue;
                }

            }

            foreach (var pairTown in towns)
            {
                Console.WriteLine($"{pairTown.Key}");
                foreach (var pairSinger in pairTown.Value.OrderByDescending(e => e.Value))
                {
                    Console.WriteLine($"#  {pairSinger.Key} -> {pairSinger.Value}");
                }
            }
        }


    }
}
