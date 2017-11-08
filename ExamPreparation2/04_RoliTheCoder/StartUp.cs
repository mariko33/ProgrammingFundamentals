using System;
using System.Collections.Generic;
using System.Linq;

namespace _04_RoliTheCoder
{
    public class StartUp
    {
        public static void Main()
        {
            List<EventN> events = new List<EventN>();
            string input;
            while ((input = Console.ReadLine()) != "Time for Code")
            {
                var inputArr = input.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                EventN ev = new EventN(int.Parse(inputArr[0]), inputArr[1]);
                for (int i = 2; i < inputArr.Count; i++)
                {
                    if (inputArr[i].Contains("@"))
                    {
                        ev.AddParticipant(inputArr[i]);
                    }

                }

                if (!ev.IsNameValid(ev.Name))
                {
                    continue;
                }



                if (events.Any(e => e.Id == ev.Id && e.Name == ev.Name))
                {
                    var evExist = events.FirstOrDefault(e => e.Id == ev.Id);
                    evExist.AddListParticipants(ev.Participants);


                }

                else if (events.Any(e => e.Id == ev.Id && e.Name != ev.Name) || events.Any(e => e.Name == ev.Name && e.Id != ev.Id))
                {
                    continue;
                }

                else if (!events.Contains(ev))
                {
                    events.Add(ev);
                }

            }

            foreach (var eve in events.OrderByDescending(e => e.Participants.Count).ThenBy(e => e.Name))
            {
                Console.WriteLine($"{eve.Name.TrimStart('#')} - {eve.Participants.Count}");
                var sortedPartisipants = eve.Participants.OrderBy(p => p).ToList();
                for (int i = 0; i < sortedPartisipants.Count; i++)
                {
                    Console.WriteLine($"{sortedPartisipants[i]}");
                }

            }

        }
    }

    public class EventN
    {
        public EventN(int id, string name)
        {
            this.Id = id;
            this.Name = name;
            this.Participants = new List<string>();
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public List<string> Participants { get; set; }

        public void AddParticipant(string participant)
        {
            if (!this.Participants.Contains(participant))
            {
                this.Participants.Add(participant);
            }

        }

        public bool IsNameValid(string name)
        {
            if (name[0] != '#')
            {
                return false;
            }
            return true;
        }

        public void AddListParticipants(List<string> partisipants)
        {
            for (int i = 0; i < partisipants.Count; i++)
            {
                if (!this.Participants.Contains(partisipants[i]))
                {
                    this.Participants.Add(partisipants[i]);
                }
            }
        }
    }
}
