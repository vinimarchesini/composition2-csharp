using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace composition2_csharp.Entities
{
    class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        public OrderItem()
        {

        }

        public OrderItem(int quantity, Product product)
        {
            Quantity = quantity;
            Product = product;
            Price = product.Price;
        }

        public double SubTotal()
        {
            return Price * Quantity;
        }

        public override string ToString()
        {
            return Product.Name + ", $" + Product.Price + ", Quantity: " + Quantity + ", Subtotal: " + "$" + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
