using System;
using System.Collections.Generic;


namespace _02_AdvertisementMessage
{
    public class StartUp
    {
        public static void Main()
        {
            string[] phrases = new[]
            {
                "Excellent product.", "Such a great product.", "I always use that product.",
                "Best product of its category.", "Exceptional product.", "I can’t live without this product."
            };

            string[] events = new[]
            {
                "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"
            };

            string[] authors = new[] {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

            string[] cities = new[] {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};
            
            Random phraseRandom=new Random();
            Random eventRandom=new Random();
            Random authorRandom=new Random();
            Random cityRandom=new Random();

            int messagesNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < messagesNumber; i++)
            {
                string phrase = phrases[phraseRandom.Next(0, phrases.Length)];
                string eventMess = events[eventRandom.Next(0, events.Length)];
                string author = authors[authorRandom.Next(0, authors.Length)];
                string city = cities[cityRandom.Next(0, cities.Length)];

                Console.WriteLine($"{phrase} {eventMess} {author} – {city}.");
            }


        }
    }
}
