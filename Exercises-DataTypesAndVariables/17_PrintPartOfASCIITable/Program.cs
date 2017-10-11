using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_PrintPartOfASCIITable
{
    class Program
    {
        static void Main()
        {
            int charFirstIndex = int.Parse(Console.ReadLine());
            int charSecondIndex = int.Parse(Console.ReadLine());
            for (int i = charFirstIndex; i <= charSecondIndex; i++)
            {
                Console.Write((char)i+" ");
            }
        }
    }
}
