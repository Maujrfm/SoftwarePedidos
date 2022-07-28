using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwarePedidos.Entities.Enums;

namespace SoftwarePedidos.Entities
{
    class Order
    {
        public OrderStatus Status { get; set; }
        public Table TableNumber { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {

        }
        public Order(OrderStatus status, Table tableNumber)
        {
            Status = status;
            TableNumber = tableNumber;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double TableBill()
        {
            double sum = 0;
            foreach(OrderItem item in Items)
            {
                sum += item.SubTotal();
            }
            return sum;
        }



    }
}
