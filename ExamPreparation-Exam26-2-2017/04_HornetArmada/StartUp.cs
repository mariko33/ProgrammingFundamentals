using System;
using System.Collections.Generic;
using System.Linq;


namespace _04_HornetArmada
{
    public class StartUp
    {
        public static void Main()
        {
            List<Legion> legions = new List<Legion>();

            int countInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < countInput; i++)
            {
                var inputArr = Console.ReadLine()
                    .Split(new[] { "=", "-", ">", ":", " " }, StringSplitOptions.RemoveEmptyEntries);

                long lastActivity = long.Parse(inputArr[0]);
                string legionName = inputArr[1];
                string soldierType = inputArr[2];
                long soldierCount = long.Parse(inputArr[3]);

                if (legions.Any(l => l.Name == legionName))
                {
                    var existLegion = legions.FirstOrDefault(l => l.Name == legionName);
                    existLegion.ChangeActivity(lastActivity);
                    existLegion.ChangeSoldierTypeCount(soldierType, soldierCount);
                }
                else
                {
                    Legion legion = new Legion(legionName, lastActivity, soldierType, soldierCount);
                    legions.Add(legion);
                }
            }

            string printCommand = Console.ReadLine();
            if (printCommand.Contains("\\"))
            {
                var commandArr = printCommand.Split(new[] { "\\" }, StringSplitOptions.RemoveEmptyEntries);
                var legionsSearch = legions
                    .Where(l => l.TypeCountOfSoldiers.ContainsKey(commandArr[1]) &&
                                l.LastActivity < int.Parse(commandArr[0]));
                    

                legionsSearch
                    .OrderByDescending(l=>l.TypeCountOfSoldiers[commandArr[1]])
                    .ToList()
                    .ForEach(l => Console.WriteLine($"{l.Name} -> {l.TypeCountOfSoldiers[commandArr[1]]}"));
            }
            else
            {
                legions
                    .Where(l => l.TypeCountOfSoldiers.ContainsKey(printCommand))
                    .OrderByDescending(l => l.LastActivity)
                    .ToList()
                    .ForEach(l => Console.WriteLine($"{l.LastActivity} : {l.Name}"));
            }

        }
    }

    public class Legion
    {
        public Legion(string name, long lastActivity, string soldierType, long soldierCount)
        {
            this.Name = name;
            this.LastActivity = lastActivity;
            this.TypeCountOfSoldiers=new Dictionary<string, long> {{soldierType,soldierCount}};
            
        }

        public string Name { get; set; }
        public long LastActivity { get; set; }
        public Dictionary<string, long> TypeCountOfSoldiers { get; set; }

        public void ChangeActivity(long newActivity)
        {
            if (this.LastActivity < newActivity)
            {
                this.LastActivity = newActivity;
            }
        }

        public void ChangeSoldierTypeCount(string type, long count)
        {
            if (this.TypeCountOfSoldiers.ContainsKey(type))
            {
                this.TypeCountOfSoldiers[type] += count;
            }
            else
            {
                this.TypeCountOfSoldiers.Add(type,count);
            }

        }
    }
}
