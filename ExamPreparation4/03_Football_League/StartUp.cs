using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;


namespace _03_Football_League
{
    public class StartUp
    {
        public static void Main()
        {
            List<FootballTeam> teams = new List<FootballTeam>();

            string key = Console.ReadLine();
            string pattern = @" (.*?) ";

            string input;
            while ((input = Console.ReadLine()) != "final")
            {
                var inputArr = input.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                var goals = inputArr[2].Split(new[] { ":" }, StringSplitOptions.RemoveEmptyEntries);
                int firstTeamGoals = int.Parse(goals[0]);
                int secondTeamGoals = int.Parse(goals[1]);

                string name1 = inputArr[0];
                name1 = name1.Replace(key, " ");

                string name2 = inputArr[1];
                name2 = name2.Replace(key, " ");

                var name1Match = Regex.Match(name1, pattern);
                string nameF = name1Match.Groups[1].Value;

                var name2Match = Regex.Match(name2, pattern);
                string nameS = name2Match.Groups[1].Value;

                FootballTeam team1 = new FootballTeam(nameF);
                FootballTeam team2 = new FootballTeam(nameS);
                team1.AddGoals(firstTeamGoals);
                team2.AddGoals(secondTeamGoals);
                int pointsFirst = 0;
                int pointsSecond = 0;
                if (firstTeamGoals < secondTeamGoals) pointsSecond = 3;
                else if (firstTeamGoals > secondTeamGoals) pointsFirst = 3;
                else if (firstTeamGoals == secondTeamGoals)
                {
                    pointsFirst = 1;
                    pointsSecond = 1;
                }
                team1.AddPoints(pointsFirst);
                team2.AddPoints(pointsSecond);

                if (!teams.Any(t => t.Name == team1.Name))
                {
                    teams.Add(team1);
                }
                else
                {
                    var existTeam = teams.FirstOrDefault(t => t.Name == team1.Name);
                    existTeam.AddGoals(firstTeamGoals);
                    existTeam.AddPoints(pointsFirst);

                }

                if (!teams.Any(t => t.Name == team2.Name))
                {
                    teams.Add(team2);
                }
                else
                {
                    var existTeam = teams.FirstOrDefault(t => t.Name == team2.Name);
                    existTeam.AddGoals(secondTeamGoals);
                    existTeam.AddPoints(pointsSecond);
                }

            }

            Console.WriteLine("League standings:");

            int count = 1;
            foreach (var team in teams.OrderByDescending(t => t.Points).ThenBy(t => t.Name))
            {
                Console.WriteLine($"{count}. {team.Name} {team.Points}");
                count++;
            }

            Console.WriteLine("Top 3 scored goals:");

            foreach (var team in teams.OrderByDescending(t => t.Goals).ThenBy(t => t.Name).Take(3))
            {
                Console.WriteLine($"- {team.Name} -> {team.Goals}");
            }
        }
    }

    public class FootballTeam
    {
        public FootballTeam(string name)
        {
            this.Name = string.Join("", name.ToUpper().ToCharArray().Reverse());
            this.Goals = 0;
            this.Points = 0;
        }

        public string Name { get; set; }
        public int Goals { get; set; }
        public int Points { get; set; }

        public void AddGoals(int goals)
        {
            this.Goals += goals;
        }

        public void AddPoints(int points)
        {
            this.Points += points;
        }
    }
}
