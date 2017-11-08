using System;
using System.Collections.Generic;
using System.Linq;


namespace _02_Ladybugs
{
    public class StartUp
    {
        public static void Main()
        {
            int sizeField = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine()
                .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            
            int[] field=new int[sizeField];
            for (int i = 0; i < sizeField; i++)
            {
                if (ladybugIndexes.Contains(i))
                {
                    field[i]=1;
                }
                else
                {
                    field[i] = 0;
                }
            }

            string input;
            while ((input=Console.ReadLine())!="end")
            {
                var inputArr = input.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

                int index = int.Parse(inputArr[0]);
                string direction = inputArr[1];
                int moving = int.Parse(inputArr[2]);

                if (index<0||index>=field.Length)
                {
                    continue;
                }
                else if(field[index]==0)
                {
                    continue;
                }
                else
                {
                    switch (direction)
                    {
                        case "right":
                            if (moving>=0)
                            {
                                MoveRight(field,index,moving);
                            }
                            else
                            {
                                MoveLeft(field,index,Math.Abs(moving));
                            }
                            break;
                        case "left":
                            if (moving>=0)
                            {
                                MoveLeft(field,index,moving);
                            }
                            else
                            {
                                MoveRight(field,index,Math.Abs(moving));
                            }
                            break;
                    }
                }




            }


            Console.WriteLine($"{String.Join(" ",field)}");

        }

        public static void MoveRight(int[]field, int index, int moving)
        {
            if (index+moving>=field.Length)
            {
                field[index] = 0;
            }
            else
            {
                field[index] = 0;
                for (int i = index+moving; i < field.Length; i+=moving)
                {
                    if (field[i]==1)
                    {
                        continue;
                    }
                    else
                    {
                        field[i] = 1;
                        break;
                    }
                }
            }
            
        }

        public static void MoveLeft(int[]field, int index, int moving)
        {
            if (index-moving<0)
            {
                field[index] = 0;
                
            }
            else
            {
                field[index] = 0;
                for (int i = index-moving; i >= 0; i-=moving)
                {
                    if (field[i]==1)
                    {
                        continue;
                    }
                    else
                    {
                        field[i] = 1;
                        break;
                    }
                    
                }
            }
        }
    }
}
