using System;


namespace _08_LettersChangeNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new[] {" ","\t"}, StringSplitOptions.RemoveEmptyEntries);

            double sum = 0;

            foreach (var element in input)
            {
                NumberChanged num=new NumberChanged(double.Parse(element.Substring(1,element.Length-2)),element[0],element[element.Length-1]);
                sum += num.GetChangedNumber();
            }

            Console.WriteLine($"{sum:f2}");
        }
    }
    

    public class NumberChanged
    {
        public NumberChanged(double numberToChange, char firstLetter, char secondLetter)
        {
            this.NumberToChange = numberToChange;
            this.FirstLetter = firstLetter;
            this.SecondLetter = secondLetter;
        }
        public double NumberToChange { get; set; }
        public char FirstLetter { get; set; }
        public char SecondLetter { get; set; }

        public double GetChangedNumber()
        {
            double result = 0;
            int firstValue = (int)this.FirstLetter;
            int lastValue = (int)this.SecondLetter;

            if (firstValue >= 97 && firstValue <= 122)
            {
                result = this.NumberToChange * (firstValue - 96);
            }
            else if (firstValue >= 65 && firstValue <= 90)
            {
                result = this.NumberToChange / (firstValue - 64);
            }

            if (lastValue >= 97 && lastValue <= 122)
            {
                result += (lastValue - 96);
            }
            else if (lastValue >= 65 && lastValue <= 90)
            {
                result -= (lastValue - 64);
            }

            return result;
        }


    }
}
