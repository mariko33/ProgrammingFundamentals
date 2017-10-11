using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_RotateAndSum
{
    class Program
    {
        static void Main()
        {
            int[] arrInput = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int rotateNumber = int.Parse(Console.ReadLine());
            int[] sumArrs=new int[arrInput.Length];
            
            //solution 2
            //int[] sumArr=RotatedArray(arrInput,1);
            //for (int i = 2; i <= rotateNumber; i++)
            //{
            //    int[]arrRotatedTemp=RotatedArray(arrInput, i);
            //    sumArr = SummArrays(sumArr, arrRotatedTemp);
            //}

            //Console.WriteLine(String.Join(" ",sumArr));

            for (int r = 1; r <= rotateNumber; r++)
            {
                for (int i = 0; i < arrInput.Length; i++)
                {
                    sumArrs[(i + r) % arrInput.Length] +=arrInput[i];
                }
                
            }

            Console.WriteLine(String.Join(" ",sumArrs));
        }

        static int[] RotatedArray(int[] arr, int rotatdeNumber)
        {
            int[] arrRoteted=new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                arrRoteted[(i + rotatdeNumber) % arr.Length] = arr[i];
            }

            return arrRoteted;
        }

        static int[] SummArrays(int[] arr1, int[] arr2)
        {
            int[] newArr=new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                newArr[i] = arr1[i] + arr2[i];
            }
            return newArr;
        }
    }
}
