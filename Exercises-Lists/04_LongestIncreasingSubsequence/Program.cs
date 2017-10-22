using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Schema;


namespace _04_LongestIncreasingSubsequence
{
    public class Program
    {
        public static void Main()
        {
            int[] input = Console.ReadLine()
                .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            
            int[] len=new int[input.Length];
            int[]prev=new int[input.Length];
            int maxLength = 0;
            int lastIndex = 0;
            
            for (int i = 0; i < input.Length; i++)
            {
                len[i] = 1;
                prev[i] = -1;

                for (int j = 0; j < i; j++)
                {
                    if (input[i]>input[j]&&len[j]>=len[i])
                    {
                        len[i] = 1 + len[j];
                        prev[i] = j;
                    }
                }

                if (maxLength<len[i])
                {
                    maxLength = len[i];
                    lastIndex = i;
                }
                
            }
            
            List<int> maxSubSequence=new List<int>();
            for (int i = 0; i < maxLength; i++)
            {
                maxSubSequence.Add(input[lastIndex]);
                lastIndex = prev[lastIndex];
            }
            maxSubSequence.Reverse();
            Console.WriteLine(String.Join(" ",maxSubSequence));
        }
    }
}
