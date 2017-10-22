using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _08_MentorGroup
{
   public class StartUp
    {
        public static void Main()
        {
            List<User>users=new List<User>();

            string inputDate;
            while ((inputDate=Console.ReadLine())!= "end of dates")
            {
                var dateArr = inputDate.Split(new[] {" ", ","}, StringSplitOptions.RemoveEmptyEntries);
                User user=new User(dateArr[0]);
                for (int i = 1; i < dateArr.Length; i++)
                {
                    DateTime currDate=DateTime.ParseExact(dateArr[i],"dd/MM/yyyy",CultureInfo.InvariantCulture);
                    user.Dates.Add(currDate);
                }

                if (users.Any(u=>u.Name==user.Name))
                {
                    var currUser = users.FirstOrDefault(u => u.Name == user.Name);
                    currUser.Dates.AddRange(user.Dates);
                }
                else
                {
                    users.Add(user);
                }
                
            }


            string inputComment;
            while ((inputComment=Console.ReadLine())!= "end of comments")
            {
                var commentArr = inputComment.Split(new[] {"-"}, StringSplitOptions.RemoveEmptyEntries);
                if (users.Any(u=>u.Name==commentArr[0]))
                {
                    var currUser = users.FirstOrDefault(u => u.Name == commentArr[0]);
                    currUser.Comments.Add(commentArr[1]);
                }
            }

            foreach (var user in users.OrderBy(u=>u.Name))
            {
                Console.WriteLine($"{user.Name}");
                Console.WriteLine("Comments:");
                user.Comments.ForEach(c=>Console.WriteLine($"- {c}"));
                Console.WriteLine("Dates attended:");
                
                foreach (var dateCurr in SortAscending(user.Dates))
                {
                    Console.WriteLine($"-- {dateCurr.ToString("dd/MM/yyyy")}");
                }
            }

        }

        static List<DateTime> SortAscending(List<DateTime> list)
        {
            list.Sort((a, b) => a.CompareTo(b));
            return list;
        }
    }

    public class User
    {
        public User(string name)
        {
            this.Name = name;
            this.Comments=new List<string>();
            this.Dates=new List<DateTime>();

        }
        public string Name { get; set; }
        public List<DateTime> Dates { get; set; }
        public List<string> Comments { get; set; }
    }
}
