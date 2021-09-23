using System;
using ProjetoDesafio.Entities.Enums;
using ProjetoDesafio.Entities;
using System.Globalization;

namespace ProjetoDesafio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do cliente: ");
            Console.Write("Name: ");
            string nomeCliente = Console.ReadLine();
            Console.Write("Email: ");
            string emailClie = Console.ReadLine();
            Console.Write("Data de Aniversário (DD/MM/YYYY): ");
            DateTime dataNiver = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o Status da Ordem: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

            Cliente cliente = new Cliente(nomeCliente, emailClie, dataNiver);
            Order order = new Order(DateTime.Now, cliente, status);

            Console.Write("Quantos itens terá essa ordem? ");
            int quanT = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quanT; i++)
            {
                Console.WriteLine($"Enter #{i} item data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Produto product = new Produto(productName, price);

                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());

                OrderItem orderItem = new OrderItem(price, quantity,product);

                order.AddItem(orderItem);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order);
        }
    }
}
