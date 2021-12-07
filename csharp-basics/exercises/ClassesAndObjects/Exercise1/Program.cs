using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Product
    {
        private string _name;
        public double Price { get; private set; }
        public int Amount { get; private set; }
 
        public Product(string name, double price, int amount)
        {
            Price = price;
            Amount = amount;
            _name = name;
        }

        public void ChangePrice(double price)
        {
            Price = price;
        }

        public void ChangeAmount(int amount)
        {
            Amount = amount;
        }

        public void PrintProduct()
        {
            Console.WriteLine("{0}, price {1:.##}, amount {2}", _name, Price, Amount);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Logitech mouse", 70.00, 14);
            Product product2 = new Product("iPhone 5s", 999.99, 3);
            Product product3 = new Product("Epson EB-U05", 440.16, 1);

            var products = new Product[] { new Product("something", 13,14), new Product("something2", 14, 14) };

            foreach (var prod in products)
            {
                prod.PrintProduct();
            }

            product1.PrintProduct();
            product2.PrintProduct();
            product3.PrintProduct();

            product1.ChangeAmount(5);
            product1.ChangePrice(75.99);

            Console.WriteLine("Changed product: ");
            product1.PrintProduct();

            Console.ReadKey();
        }
    }
}
