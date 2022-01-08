using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Product
    {
        private double _price;
        private int _amount;
        private string _name;

        public int Amount { get => _amount; }
        public double Price { get => _price; }
        public string Name { get => _name; }

        public Product(string name, double price, int amount)
        {
            _price = price > 0 ? price : throw new Exception("Price must be above 0");
            _amount = amount >= 0 ? amount : throw new Exception("Amount must be positive");
            _name = !String.IsNullOrEmpty(name) ? name : throw new Exception("Product name must not be empty or null");
        }

        public string PrintProduct()
        {
            string formatedPrice = Math.Round(_price, 2).ToString();
            return $"{_name}, price {formatedPrice}, amount {_amount}\n";
        }

        public void ChangePrice(double newPrice)
        {
            if (newPrice < 0) { throw new Exception("Price can not be negative"); }
            _price = newPrice;
        }

        public void ChangeQuantity(int newAmount)
        {
            if (newAmount < 0) { throw new Exception("Quantity can not be negative"); }
            _amount = newAmount;
        }

        public void ChangePrice(double amount)
        {
            _price = amount;
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

            product1.ChangeQuantity(5);
            product1.ChangePrice(75.99);

            Console.WriteLine("Changed product: ");
            product1.PrintProduct();

            Console.ReadKey();
        }
    }
}
