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
        public DateTime Date { get; set; }
        public OrderStatus Status { get; set; }
        public OrdemItem OrdemItem { get; set; }
        public Client Client { get; set; }
        public List<OrdemItem> Items { get; set; } = new List<OrdemItem>();
        public Order()
        {

        }

        public Order(DateTime date)
        {
            Date = date;
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
                sum += OrdemItem.SubTotal();
            }
            return sum;
        }   
    }
}
