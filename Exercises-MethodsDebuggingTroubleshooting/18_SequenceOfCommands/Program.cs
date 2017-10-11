using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_SequenceOfCommands
{
    class Program
    {
        private const char ArgumentsDelimiter = ' ';

        public static void Main()
        {
            int sizeOfArray = int.Parse(Console.ReadLine());

            long[] array = Console.ReadLine()
                .Split(ArgumentsDelimiter)
                .Select(long.Parse)
                .ToArray();

            string command;

            while (!(command= Console.ReadLine()).Equals("stop"))
            {
               // string line = Console.ReadLine().Trim();
                string[] stringParams = command.Split(ArgumentsDelimiter);
                int[] args = new int[2];

                if (stringParams[0].Equals("add") ||
                    stringParams[0].Equals("subtract") ||
                    stringParams[0].Equals("multiply"))
                {
                    //string[] stringParams = line.Split(ArgumentsDelimiter);
                    args[0] = int.Parse(stringParams[1]);
                    args[1] = int.Parse(stringParams[2]);

                    PerformAction(array, stringParams[0], args);
                }

                else
                {
                    PerformAction(array, stringParams[0], args);
                }

                //PrintArray(array);
                //Console.WriteLine('\n');

                //command = Console.ReadLine();
            }
        }

        static void PerformAction(long[] arr, string action, int[] args)
        {
           // long[] array = arr.Clone() as long[];
            int pos = args[0];
            int value = args[1];

            switch (action)
            {
                case "multiply":
                    arr[pos-1] *= value;
                    break;
                case "add":
                    arr[pos-1] += value;
                    break;
                case "subtract":
                    arr[pos-1] -= value;
                    break;
                case "lshift":
                    ArrayShiftLeft(arr);
                    break;
                case "rshift":
                    ArrayShiftRight(arr);
                    break;
            }
            
            PrintArray(arr);
        }

        private static void ArrayShiftRight(long[] array)
        {
            long temp = array[array.Length - 1];
            for (int i = array.Length - 1; i >= 1; i--)
            {
             
                array[i] = array[i - 1];
            }
            array[0] = temp;
        }

        private static void ArrayShiftLeft(long[] array)
        {
            long temp = array[0];
            for (int i = 0; i < array.Length - 1; i++)
            {
                
                array[i] = array[i + 1];
            }
            array[array.Length - 1] = temp;
        }

        private static void PrintArray(long[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
