using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExEnumsProposto.Entities;
using ExEnumsProposto.Entities.Enums;

namespace ExEnumsProposto.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public OrdemItem OrdemItem { get; set; }
        public Client Client { get; set; }
        public List<OrdemItem> Items { get; set; } = new List<OrdemItem>();
        public Order()
        {

        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client; // nao tinha colocado isso, olhado na revisao
        }
        public void AddItem(OrdemItem items)
        {
            Items.Add(items);
        }
        public void RemoveItem(OrdemItem items)
        {
            Items.Remove(items);
        }
        public double Total()
        {
            double sum = 0.0;
            foreach (OrdemItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Oder moment: " + Moment.ToString("dd/MM/yyyy hh:mm:ss"));
            sb.Append("Order status: " + Status);
            sb.Append("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach(OrdemItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total().ToString("F2"));
            return sb.ToString();
        }

    }
}
