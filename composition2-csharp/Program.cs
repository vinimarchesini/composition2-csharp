using System;
using System.Globalization;
using composition2_csharp.Entities;
using composition2_csharp.Entities.Enums;

namespace composition2_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            TestOrder();
        }

        public static void TestOrder()
        {
            Client cliente = new Client("Vini", "vini@gmail.com", DateTime.Parse("16/09/1993"));
            Order pedidos = new Order(Enum.Parse<OrderStatus>("Delivered"), cliente);
            Product prod1 = new Product("TV", 1500.00);
            OrderItem item1 = new OrderItem(2, prod1);
            Product prod2 = new Product("PS4", 1800.00);
            OrderItem item2 = new OrderItem(2, prod2);
            pedidos.AddItem(item1);
            pedidos.AddItem(item2);
            Console.WriteLine(pedidos);
        }
    }
}
