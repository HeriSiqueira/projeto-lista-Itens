using System;
using ProjetoDesafio.Entities.Enums;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ProjetoDesafio.Entities
{
    class Order
    {
        public DateTime Momento { get; set; }
        public Cliente Cliente { get; set; }
        public OrderStatus StatusDaOrdem { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();


        public Order()
        {
        }

        public Order(DateTime momento, Cliente cliente, OrderStatus statusDaOrdem)
        {
            Momento = momento;
            Cliente = cliente;
            StatusDaOrdem = statusDaOrdem;
        }

        public void AddItem(OrderItem itens)
        {
            Items.Add(itens);
        }

        public void RemoveItem(OrderItem itens)
        {
            Items.Remove(itens);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Momento.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + StatusDaOrdem);
            sb.AppendLine("Client: " + Cliente);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
