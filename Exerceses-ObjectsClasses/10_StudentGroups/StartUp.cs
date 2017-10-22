using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _10_StudentGroups
{
    public class StartUp
    {
        public static void Main()
        {
            List<Town> towns = new List<Town>();

            string input = Console.ReadLine();
            
            bool isRunning = true;
            while (isRunning)
            {
                if (input.Contains("=>"))
                {
                    var inputTown = input.Split(new[] { "=>" }, StringSplitOptions.RemoveEmptyEntries);
                    var seatsArr = inputTown[1].Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    Town town = new Town(inputTown[0], int.Parse(seatsArr[0].Trim()));
                    
                    List<Student> students = new List<Student>();

                    string inputStudents = Console.ReadLine();

                    while (inputStudents.Contains("|"))
                    {
                        var studentArr = inputStudents.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                        
                        Student student = new Student(studentArr[0].Trim(), studentArr[1].Trim(),
                            DateTime.ParseExact(studentArr[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture));
                        
                        students.Add(student);
                        
                        inputStudents = Console.ReadLine();
                    }

                    town.AddMembers(students);
                    towns.Add(town);
                    

                    if (inputStudents == "End")
                    {
                        isRunning = false;
                    }
                    if (inputStudents.Contains("=>"))
                    {
                        input = inputStudents;
                    }

                }

            }

            Console.WriteLine($"Created {towns.Sum(t => t.Groups.Count)} groups in {towns.Count} towns:");

            foreach (var town in towns.OrderBy(t => t.Name))
            {
                string name = town.Name;
                foreach (var group in town.Groups)
                {
                    Console.WriteLine($"{name}=> {String.Join(", ", group.Value.Select(s => s.Email))}");
                }
            }
        }
    }

    public class Student
    {
        public Student(string name, string email, DateTime registrationDate)
        {
            this.Name = name;
            this.Email = email;
            this.RegistrationDate = registrationDate;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    
    public class Town
    {
        public Town(string name, int groupCapacity)
        {
            this.Name = name;
            this.GroupCapasity = groupCapacity;
            this.Groups = new Dictionary<int, List<Student>>();
        }
        public string Name { get; set; }
        public int GroupCapasity { get; set; }
        public Dictionary<int, List<Student>> Groups;

        public void AddMembers(List<Student> students)
        {
            if (students.Count <= GroupCapasity)
            {
                Groups.Add(1, students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email).ToList());
            }
            else
            {
                int groupCount;
                
                if (students.Count % GroupCapasity == 0)
                {
                    groupCount = students.Count / GroupCapasity;
                }
                else
                {
                    groupCount = students.Count / GroupCapasity + 1;
                }

                var sortedStudents = students.OrderBy(s => s.RegistrationDate).ThenBy(s => s.Name).ThenBy(s => s.Email).ToList();

                for (int i = 1; i <= groupCount; i++)
                {
                    int currRange = Math.Min(GroupCapasity, sortedStudents.Count);
                    var currStudent = sortedStudents.GetRange(0, currRange);
                    Groups.Add(i, currStudent);
                    sortedStudents.RemoveRange(0, currRange);
                }
            }
        }
    }
}
