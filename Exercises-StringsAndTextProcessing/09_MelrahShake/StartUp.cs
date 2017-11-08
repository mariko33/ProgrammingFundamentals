using System;
using System.Text.RegularExpressions;


namespace _09_MelrahShake
{
    public class StartUp
    {
        public static void Main()
        {
            string textSearching = Console.ReadLine();
            string pattern = Console.ReadLine();

            int numberOfMatches;


            while (textSearching.Length > 0 && pattern.Length > 0)  //100/100
            {
                int first = textSearching.IndexOf(pattern);
                int last = textSearching.LastIndexOf(pattern);

                if (first >= 0 && last >= 0 && first != last)
                {
                    Console.WriteLine("Shaked it.");

                    textSearching = textSearching.Remove(last, pattern.Length);
                    textSearching = textSearching.Remove(first, pattern.Length);

                    pattern = pattern.Remove(pattern.Length / 2, 1);


                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(textSearching);
                    break;
                }

                //90/100
                //var matchArr = Regex.Matches(textSearching, pattern);
                //numberOfMatches = Regex.Matches(textSearching, pattern).Count;

                //if (numberOfMatches >= 2)
                //{
                //    int firstMatch = matchArr[0].Index;
                //    int lastIndex = matchArr[matchArr.Count - 1].Index;

                //    Console.WriteLine("Shaked it.");

                //    //textSearching = textSearching.Remove(firstMatch, pattern.Length);
                //    //lastIndex = textSearching.LastIndexOf(pattern);
                //    //textSearching = textSearching.Remove(lastIndex, pattern.Length);

                //    textSearching = textSearching.Remove(lastIndex, pattern.Length);
                //    textSearching = textSearching.Remove(firstMatch, pattern.Length);

                //    pattern = pattern.Remove(pattern.Length / 2, 1);

                //}
                //else
                //{
                //    Console.WriteLine("No shake.");
                //    Console.WriteLine(textSearching);
                //    break;
                //}


            }

            if (textSearching.Length < 1 || pattern.Length < 1)
            {
                Console.WriteLine("No shake.");
                Console.WriteLine(textSearching);
            }




        }
    }
}
