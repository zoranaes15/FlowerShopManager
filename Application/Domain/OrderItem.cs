using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain
{
    public class OrderItem : Entity
    {
        public Order Order { get; private set; }
        public Product Product { get; private set; }
        public int Quantity { get; private set; }
        public double UnitPrice { get; private set; }

        public OrderItem() 
        {
            Order = new Order();
            Product = new Product();
            Quantity = 0;
            UnitPrice = 0.0;
        }
        public OrderItem(Order order, Product product, int quantity, double unitPrice)
        {
            Order = order;
            Product = product;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }

    }
}
