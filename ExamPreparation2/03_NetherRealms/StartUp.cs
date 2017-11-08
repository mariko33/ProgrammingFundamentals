using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03_NetherRealms
{
    public class StartUp
    {
        public static void Main()
        {
            List<Demon>demons=new List<Demon>();
            var input = Console.ReadLine()
                .Split(new[] { " ", ",", "\t", Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < input.Length; i++)
            {
                Demon demon=new Demon(input[i]);
                demons.Add(demon);
            }

            foreach (var d in demons.OrderBy(d=>d.Name))
            {
                Console.WriteLine($"{d.Name} - {d.DemonHealth()} health, {d.Damage():f2} damage");
            }

        }
    }

    public class Demon
    {
        public Demon(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }

        public double DemonHealth()
        {
          
           string pattern= @"[^\d\.\+\-\*\/\s\,]";
            var healthMatch = Regex.Matches(this.Name, pattern);
            string healthStr=String.Empty;

            foreach (Match m in healthMatch)
            {
                healthStr += m.Value;
            }

            double health = 0;

            for (int i = 0; i < healthStr.Length; i++)
            {
                health += (int)healthStr[i];
            }

            return health;
        }

        public double Damage()
        {
           
            string pattern = @"([-+]?(\d+\.)?\d+)";
            string patternOperation= @"[*\/]";

            var operationCollection = Regex.Matches(this.Name, patternOperation);
            var damageCollection = Regex.Matches(this.Name, pattern);
            
            double damage = 0;
            foreach (Match m in damageCollection)
            {
                if (m.Value[0]=='+'||m.Value[0]=='-')
                {
                    double damageDigit = double.Parse(m.Value.Substring(1));
                    if (m.Value[0] == '+') damage += damageDigit;
                    else damage -= damageDigit;
                }
                else
                {
                    damage += double.Parse(m.Value);
                }
            }

            foreach (Match m in operationCollection)
            {
                if (m.Value == "*") damage *= 2;
                else damage /= 2;

            }

            return damage;
        }
    }
}
