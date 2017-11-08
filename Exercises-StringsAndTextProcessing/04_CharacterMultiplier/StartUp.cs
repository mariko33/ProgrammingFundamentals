using System;


namespace _04_CharacterMultiplier
{
   public class StartUp
    {
       public static void Main()
       {
           var input = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);

           var firstStr = input[0];
           var secondStr = input[1];

           int result = 0;
           int minLength = Math.Min(firstStr.Length, secondStr.Length);

           for (int i = 0; i < minLength; i++)
           {
               result += (int)(firstStr[i]) * (int)(secondStr[i]);
           }

           if (firstStr.Length!=secondStr.Length)
           {
               string biggerString = GetBigger(firstStr, secondStr);
               result += GetSubstringSum(biggerString, minLength);
           }

           Console.WriteLine(result);
           

       }


        public static int GetSubstringSum(string bigger, int minLength)
        {
            string subBigger = bigger.Substring(minLength);
            int result = 0;
            for (int i = 0; i < subBigger.Length; i++)
            {
                result += (int)(subBigger[i]);
            }

            return result;
        }
        
        public static string GetBigger(string first, string second)
        {
            int maxLength = Math.Max(first.Length, second.Length);
            if (first.Length==maxLength)
            {
                return first;
            }
            return second;
        }
    }
}
