using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BlankReceipt
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintReceipt();
        }

        static void PrintReceipt()
        {
            PrintHeader();
            PrintBody();
            PrintFooter();
        }
        
        static void PrintHeader()
        {
            Console.WriteLine($"CASH RECEIPT{Environment.NewLine}------------------------------");
            
        }

        static void PrintBody()
        {
            Console.WriteLine($"Charged to____________________{Environment.NewLine}Received by___________________");
        }

        static void PrintFooter()
        {
            Console.WriteLine($"------------------------------{Environment.NewLine}\u00A9 SoftUni");
        }
        
    }
}
