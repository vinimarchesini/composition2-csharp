using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using composition2_csharp.Entities.Enums;

namespace composition2_csharp.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Order()
        {
            Moment = DateTime.Now;
        }

        public Order(OrderStatus status, Client client) : this()
        {
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double sum = 0.0;
            foreach (OrderItem s in Items)
            {
                sum += s.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("OrderMoment: " + Moment);
            sb.AppendLine("OrderStatus: " + Status);
            sb.AppendLine("Client: " + Client.Name + " (" + Client.BirthDate.ToString("dd/MM/yyyy") + ")" + " - " + Client.Email);
            sb.AppendLine("Order Items:");
            foreach (OrderItem orderItem in Items)
            {
                sb.AppendLine(orderItem.ToString());
            }
            sb.AppendLine("Total Price: " + Total().ToString("F2", CultureInfo.InvariantCulture));
            return sb.ToString();
        }
    }
}
