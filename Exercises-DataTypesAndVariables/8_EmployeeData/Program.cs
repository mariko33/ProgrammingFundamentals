using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_EmployeeData
{
    class Program
    {
        static void Main()
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalId = long.Parse(Console.ReadLine());
            int uniqueEmploeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: "+firstName);
            Console.WriteLine("Last name: "+lastName);
            Console.WriteLine("Age: "+age);
            Console.WriteLine("Gender: "+gender);
            Console.WriteLine("Personal ID: "+ personalId);
            Console.WriteLine("Unique Employee number: "+uniqueEmploeeNumber);


        }
    }
}
