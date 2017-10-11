using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_FoldAndSum
{
    class Program
    {
        static void Main()
        {
            int[] inputArr = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int foldNumber = inputArr.Length / 4;
            int middleCount = 2 * foldNumber;
            int[] foldArrLeft=new int[foldNumber];
            int[] foldArrRight= new int[foldNumber];


            for (int i = 0; i < foldNumber; i++)
            {
                foldArrLeft[i] = inputArr[i];

            }
            
            foldArrLeft = foldArrLeft.Reverse().ToArray();

            for (int i = 0; i < foldNumber; i++)
            {
                foldArrRight[i] = inputArr[inputArr.Length - foldNumber+i];
            }

            foldArrRight = foldArrRight.Reverse().ToArray();
            
            int[] foldArr=foldArrLeft.Concat(foldArrRight).ToArray();
            
            int[] middleArr=new int[2*foldNumber];
            
            for (int i = 0; i < middleArr.Length; i++)
            {
                middleArr[i] = inputArr[foldNumber + i];
            }

            int[] result = SummArrays(foldArr, middleArr);

            Console.WriteLine(String.Join(" ",result));
            
        }

        static int[] SummArrays(int[] arr1, int[] arr2)
        {
            int[] newArr = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i] + arr2[i];
            }
            return newArr;
        }
    }
}
