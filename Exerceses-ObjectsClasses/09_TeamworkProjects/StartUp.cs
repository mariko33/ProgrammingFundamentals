using System;
using System.Collections.Generic;
using System.Linq;

namespace _09_TeamworkProjects
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string,Team>creatorTeam=new Dictionary<string, Team>();

            int countInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < countInput; i++)
            {
                var inputArr = Console.ReadLine()
                    .Split(new[] {"-"}, StringSplitOptions.RemoveEmptyEntries);
                
                Team curr=new Team(inputArr[1]);

                if (creatorTeam.Any(kv => kv.Value.Name == inputArr[1]))
                {
                    Console.WriteLine($"Team {inputArr[1]} was already created!");
                    continue;
                }
                
                if (creatorTeam.ContainsKey(inputArr[0])||creatorTeam.Values.Any(t=>t.Members.Contains(inputArr[0])))
                {
                    Console.WriteLine($"{inputArr[0]} cannot create another team!" );
                    continue;
                }
                
                
                creatorTeam.Add(inputArr[0],curr);
                Console.WriteLine($"Team {inputArr[1]} has been created by {inputArr[0]}!");

            }

            string inputJoin;
            while ((inputJoin=Console.ReadLine())!= "end of assignment")
            {

                var joinArr = inputJoin.Split(new[] {"->"}, StringSplitOptions.RemoveEmptyEntries);
                string member = joinArr[0];
                string teamName = joinArr[1];

                if (!creatorTeam.Any(kv=>kv.Value.Name==teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                    continue;
                }

                if (creatorTeam.Any(kv=>kv.Value.Members.Contains(member))||creatorTeam.ContainsKey(member))
                {
                   
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                    continue;
                }

                Team targetTeam = creatorTeam.Values.FirstOrDefault(t => t.Name == teamName);
                targetTeam.AddMember(member);
               
            }

            foreach (var creatorTeamPair in creatorTeam.OrderByDescending(kv=>kv.Value.Members.Count).ThenBy(kv=>kv.Value.Name))
            {
                if (creatorTeamPair.Value.Members.Count>0)
                {
                    Console.WriteLine($"{creatorTeamPair.Value.Name}");
                    Console.WriteLine($"- {creatorTeamPair.Key}");
                    foreach (var member in creatorTeamPair.Value.Members.OrderBy(n => n))
                    {
                        Console.WriteLine($"-- {member}");
                    }
                } 
            }

            Console.WriteLine("Teams to disband:");

            var disbandTeams = creatorTeam.Values.Where(t => t.Members.Count == 0).ToList();
            if (disbandTeams.Count>0)
            {
                disbandTeams.OrderBy(d=>d.Name).ToList().ForEach(t=>Console.WriteLine($"{t.Name}"));
            }



        }
    }

    public class Team
    {
        public Team(string name)
        {
            this.Name = name;
            this.Members=new List<string>();
        }
        
        public string Name { get; set; }

        public List<string> Members { get; set; }

        public void AddMember(string name)
        {
            if (Members.Contains(name))
            {
                Console.WriteLine($"Member {name} cannot join team {this.Name}!");
                
            }
            else
            {
                Members.Add(name);
            }
            
        }
    }
}
