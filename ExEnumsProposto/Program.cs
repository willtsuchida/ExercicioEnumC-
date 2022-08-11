using System;
using ExEnumsProposto.Entities;
using ExEnumsProposto.Entities.Enums;

namespace ExEnumsProposto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate = DateTime.Parse(Console.ReadLine());

            Client client = new Client(name, email, birthDate);

            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            DateTime moment = DateTime.Now;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                String productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Product product = new Product(productName, price);
                OrdemItem ordemItem = new OrdemItem(quantity, product.Price);
                
                
            }
            Order order = new Order(moment, status);

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);




        }
    }
}
