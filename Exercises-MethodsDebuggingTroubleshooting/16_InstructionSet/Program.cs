using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_InstructionSet
{
    class Program
    {
        static void Main()
        {
            string opCode;

            while ((opCode = Console.ReadLine().ToUpper()) != "END")
            {
                string[] codeArgs = opCode.Split(' ');

                long result = 0;
                switch (codeArgs[0])
                {
                    case "INC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = ++operandOne;
                        break;

                    }
                    case "DEC":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        result = --operandOne;
                        break;
                    }

                    case "ADD":
                    {
                        long operandOne = long.Parse(codeArgs[1]);
                        long operandTwo = long.Parse(codeArgs[2]);
                        result = operandOne + operandTwo;
                        break;
                    }

                    case "MLA":
                    {
                        long inputOne = long.Parse(codeArgs[1]);
                        long inputTwo = long.Parse(codeArgs[2]);
                        result = inputOne * inputTwo;
                        break;
                    }

                }

                Console.WriteLine(result);
            }
        }
    }
}
