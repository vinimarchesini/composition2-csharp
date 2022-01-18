using System;
using System.Collections.Generic;
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
        }
    }
}
