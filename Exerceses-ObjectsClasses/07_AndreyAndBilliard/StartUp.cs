using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace _07_AndreyAndBilliard
{
    public class StartUp
    {
        public static void Main()
        {
            List<Product> products = new List<Product>();
            List<Client> clients = new List<Client>();

            int countInput = int.Parse(Console.ReadLine());
            for (int i = 0; i < countInput; i++)
            {
                var inputProduct = Console.ReadLine()
                    .Split(new[] { "-" }, StringSplitOptions.RemoveEmptyEntries);
                
                Product product = new Product(inputProduct[0], decimal.Parse(inputProduct[1]));

                if (products.Any(p => p.Name == product.Name))
                {
                    var repeatProduct = products.Find(p => p.Name == product.Name);
                    repeatProduct.Price = product.Price;
                }
                else
                {
                    products.Add(product);
                }

            }

            string inputClient;

            while ((inputClient=Console.ReadLine())!= "end of clients")
            {
                var clientArr = inputClient.Split(new[] {"-", ","}, StringSplitOptions.RemoveEmptyEntries);
                string name = clientArr[0];
                
                if (!products.Any(p=>p.Name==clientArr[1]))
                {
                    continue;
                }
                
                Product product = products.FirstOrDefault(p => p.Name == clientArr[1]);
                int quantity = int.Parse(clientArr[2]);
                var client=new Client(name);
                client.ProductsQuantity.Add(product,quantity);

                if (clients.Any(c=>c.Name==client.Name))
                {
                    var existClient = clients.FirstOrDefault(c => c.Name == client.Name);
                    
                    if (existClient.ProductsQuantity.ContainsKey(client.ProductsQuantity.First().Key))
                    {
                        existClient.ProductsQuantity[client.ProductsQuantity.First().Key] +=
                            client.ProductsQuantity.First().Value;
                    }
                    else
                    {
                      existClient.ProductsQuantity.Add(client.ProductsQuantity.First().Key,client.ProductsQuantity.First().Value);  
                    }
                }
                else
                {
                    clients.Add(client);
                }
                
                
            }

            decimal totalBill = 0;
            decimal clientBill = 0;
           

            foreach (var client in clients.OrderBy(c=>c.Name))
            {
                Console.WriteLine($"{client.Name}");
                
                foreach (var prod in client.ProductsQuantity)
                {
                    Console.WriteLine($"-- {prod.Key.Name} - {prod.Value}");
                    clientBill += client.GetBill(prod.Key, prod.Value);
                }
                Console.WriteLine($"Bill: {clientBill:f2}");
                totalBill += clientBill;
                clientBill = 0;

            }
            Console.WriteLine($"Total bill: {totalBill:f2}");
        }
    }

    public class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class Client
    {
        public Client(string name)
        {
            Name = name;
            ProductsQuantity = new Dictionary<Product, int>();
            
        }
        public string Name { get; set; }
        public Dictionary<Product,int> ProductsQuantity { get; set; }

        public decimal GetBill(Product product,int quantity)
        {
            return product.Price * quantity;
        }
    }
}
