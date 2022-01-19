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
            //Create Vars
            string clientName, clientEmail;
            OrderStatus orderStatus;
            DateTime clientBd;
            int qttItems;
            Client client;
            Order order;
            //TestOrder();

            //Ask client and order informations
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            clientName = Console.ReadLine();
            Console.Write("Email: ");
            clientEmail = Console.ReadLine();
            Console.Write("Birthdate (DD/MM/YYYY): ");
            clientBd = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter order data:");
            Console.Write("Status: ");
            orderStatus = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How Many items to this order? ");
            qttItems = int.Parse(Console.ReadLine());

            //instantiate Client
            client = new Client(clientName, clientEmail, clientBd);

            //instantiate Order
            order = new Order(orderStatus, client);

            //Ask items information and Add to order based on qtt
            for (int i = 1; i <= qttItems; i++)
            {
                Console.WriteLine("Enter #" + i + " data:");
                Console.Write("Product name: ");
                string productName = Console.ReadLine();
                Console.Write("Product price: ");
                double productPrice = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int productQtt = int.Parse(Console.ReadLine());
                Product product = new Product(productName, productPrice);
                OrderItem orderItem = new OrderItem(productQtt, product);
                order.AddItem(orderItem);
            }

            //Print Order Summary:
            Console.WriteLine(order);

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
