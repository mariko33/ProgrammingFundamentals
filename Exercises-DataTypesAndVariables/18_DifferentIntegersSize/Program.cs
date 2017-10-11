using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _18_DifferentIntegersSize
{
    class Program
    {
        static void Main()
        {

            string inputString = Console.ReadLine();
            
            List<string> resultList=new List<string>();
            string sbytes = "sbyte";
            string bytes = "byte";
            string shorts = "short";
            string ushorts = "ushort";
            string ints = "int";
            string uints = "uint";
            string longs = "long";

            try
            {
                long input = long.Parse(inputString);
                if (input>=sbyte.MinValue&&input<=sbyte.MaxValue)
                {
                    resultList.Add(sbytes);
                }
                if (input>=byte.MinValue&&input<=byte.MaxValue)
                {
                    resultList.Add(bytes);
                }
                if (input>=short.MinValue&&input<=short.MaxValue)
                {
                    resultList.Add(shorts);
                }
                if (input >= ushort.MinValue && input <= ushort.MaxValue)
                {
                    resultList.Add(ushorts);
                }
                if (input >= int.MinValue && input <= int.MaxValue)
                {
                    resultList.Add(ints);
                }
                if (input >= uint.MinValue && input <= uint.MaxValue)
                {
                    resultList.Add(uints);
                }
                if (input >= long.MinValue && input <= long.MaxValue)
                {
                    resultList.Add(longs);
                }

                Console.WriteLine($"{input} can fit in:");
                resultList.ForEach(r => Console.WriteLine($"* {r}"));
            }
            catch 
            {
                Console.WriteLine($"{inputString} can't fit in any type");
                
            }

            
            
        }
    }
}
