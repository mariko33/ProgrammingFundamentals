using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Sockets;

namespace _05_BookLibrary
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Book>books=new List<Book>();
            Library library=new Library("ABC",books);

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                var input = Console.ReadLine()
                    .Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string title = input[0];
                string author = input[1];
                string publsher = input[2];
                DateTime releaseDate=DateTime.ParseExact(input[3],"dd.MM.yyyy",CultureInfo.InvariantCulture);
                string isbn = input[4];
                decimal price = decimal.Parse(input[5]);
                
                Book book=new Book(title,author,publsher,releaseDate,isbn,price);
                
                library.Books.Add(book);
            }

            string inputDate = Console.ReadLine();
            DateTime givenDate=DateTime.ParseExact(inputDate,"dd.MM.yyyy",CultureInfo.InvariantCulture);
            
           //Problem _05
            var authorSums = library.Books.GroupBy(
                b => b.Author,
                b => b.Price,
                (key, value) => new { Author = key, Sum = books.Where(b => b.Author == key).Sum(b => b.Price)})
                .OrderByDescending(kv=>kv.Sum)
                .ThenBy(kv=>kv.Author);

            //foreach (var res in authorSums)
            //{
            //    Console.WriteLine($"{res.Author} -> {res.Sum:f2}");
            //}


            //Probloem _06
             books
                .Where(b => b.ReleaseDate > givenDate)
                .OrderBy(b=>b.ReleaseDate)
                .ThenBy(b=>b.Title)
                .ToList()
                .ForEach(b=>Console.WriteLine($"{b.Title} -> {b.ReleaseDate.ToString("dd.MM.yyyy")}"));
            
            


        }
    }

    public class Book
    {
        public Book(string title, string author, string publisher, DateTime releaseDate, string isbn, decimal price)
        {
            Title = title;
            Author = author;
            Publisher = publisher;
            ReleaseDate = releaseDate;
            Isbn = isbn;
            Price = price;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Isbn { get; set; }
        public Decimal Price { get; set; }
    }

    public class Library
    {
        public Library(string name, List<Book> books)
        {
            Name = name;
            Books = books;
        }
        
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
