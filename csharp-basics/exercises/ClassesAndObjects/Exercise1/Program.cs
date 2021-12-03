using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Product
    {
        public double price;
        public int amount;
        string name;

        public Product(string name, double price, int amount)
        {
            this.price = price;
            this.amount = amount;
            this.name = name;
        }

        public void PrintProduct()
        {
            Console.WriteLine("{0}, price {1:.##}, amount {2}", this.name, this.price, this.amount);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Logitech mouse", 70.00, 14);
            Product product2 = new Product("iPhone 5s", 999.99, 3);
            Product product3 = new Product("Epson EB-U05", 440.16, 1);

            product1.PrintProduct();
            product2.PrintProduct();
            product3.PrintProduct();

            product1.amount = 5;
            product1.price = 75.99;

            Console.WriteLine("Changed product: ");
            product1.PrintProduct();

            Console.ReadKey();
        }
    }
}
