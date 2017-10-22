using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;


namespace _04_AverageGrades
{
    public class Program
    {
        public static void Main()
        {

            int count = int.Parse(Console.ReadLine());
            List<Student>students=new List<Student>();

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries).ToList();

                string name = input[0];

                List<double> grades = input
                    .GetRange(1, input.Count - 1)
                    .Select(double.Parse)
                    .ToList();
                
                Student student=new Student(name,grades);
                students.Add(student);

            }

          students
                .Where(s => s.AverageGrade >= 5)
                .OrderBy(s => s.Name)
                .ThenByDescending(s => s.AverageGrade)
                .ToList()
                .ForEach(s => Console.WriteLine($"{s.Name} -> {s.AverageGrade:f2}"));






        }



    }
}




public class Student
{
    public Student(string name, List<double> grades)
    {
        this.Name = name;
        this.Grades = grades;
    }

    public string Name { get; set; }
    public List<double> Grades { get; set; }
    public double AverageGrade => this.Grades.Average();


}


