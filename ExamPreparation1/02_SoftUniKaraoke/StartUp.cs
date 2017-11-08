using System;
using System.Collections.Generic;
using System.Linq;


namespace _02_SoftUniKaraoke
{
   public class StartUp
    {
       public static void Main()
        {
            List<Participant>participants=new List<Participant>();
            List<string>songs=new List<string>();
            List<string>songParticipants=new List<string>();

            var inputParticipanst = Console.ReadLine()
                .Split(new[] {",", " ", "  "}, StringSplitOptions.RemoveEmptyEntries);

            foreach (var part in inputParticipanst)
            {
                Participant participant=new Participant(part);
                participants.Add(participant);
            }

            var inputSongs = Console.ReadLine().Split(new[] {","}, StringSplitOptions.RemoveEmptyEntries);
            foreach (var song in inputSongs)
            {
                songs.Add(song.Trim());
            }

            string input;

            while ((input=Console.ReadLine())!="dawn")
            {
                var inputArr = input.Split(new[] {", ", ",  "}, StringSplitOptions.RemoveEmptyEntries);
                
                string nameParticipant = inputArr[0];
                string songSing = inputArr[1];
                string award = inputArr[2];

                if (participants.Any(p => p.Name == nameParticipant) && songs.Contains(songSing))
                {
                    if (!songParticipants.Contains(nameParticipant))
                    {
                       songParticipants.Add(nameParticipant); 
                    }
                    
                    var currentPartcicpant = participants.FirstOrDefault(p => p.Name == nameParticipant);
                    if (!currentPartcicpant.Awards.Contains(award))
                    {
                        currentPartcicpant.Awards.Add(award);
                    }

                }

            }

            List<Participant>finalList=new List<Participant>();
            foreach (var person in songParticipants)
            {
                var finalPart = participants.FirstOrDefault(p => p.Name == person);
                finalList.Add(finalPart);

            }

            if (finalList.Count == 0)
            {
                Console.WriteLine("No awards");
            }
            else
            {
                foreach (var part in finalList.OrderByDescending(p => p.Awards.Count).ThenBy(p => p.Name))
                {
                    Console.WriteLine($"{part.Name}: {part.Awards.Count} awards");
                    foreach (var a in part.Awards.OrderBy(x => x))
                    {
                        Console.WriteLine($"--{a}");
                    }


                }
            }
            

        }
    }

    public class Participant
    {
        public Participant(string name)
        {
            this.Name = name;
            this.Awards=new List<string>();
        }
        
        public string Name { get; set; }
        public List<string>Awards { get; set; }
    }
}
