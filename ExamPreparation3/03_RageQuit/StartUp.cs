using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_RageQuit
{
    public class StartUp
    {
        public static void Main()
        {
            string pattern = @"([^\d]+)(\d+)";
            List<Sequence> sequences = new List<Sequence>();

            string input = Console.ReadLine();

            var inputCollection = Regex.Matches(input, pattern);
            foreach (Match coll in inputCollection)
            {
                Sequence sequence = new Sequence(coll.Groups[1].Value, int.Parse(coll.Groups[2].Value));
                sequences.Add(sequence);
            }
            var result = sequences.Select(s => s.RepeateSequence()).ToList();

            var resultUnique = String.Join("", result).Distinct().ToList();


            Console.WriteLine($"Unique symbols used: {resultUnique.Count}");
            Console.WriteLine($"{String.Join("", result)}");
        }
    }

    public class Sequence
    {
        public Sequence(string name, int count)
        {
            this.Name = name.ToUpper();
            this.Count = count;
        }
        public string Name { get; set; }
        public int Count { get; set; }

        public string RepeateSequence()
        {
            string result = string.Concat(Enumerable.Repeat(this.Name, this.Count));
            return result;
        }
    }
}
