using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain
{
    public enum OrderStatus { 
        Pending,
        Processing,
        Completed,
        Cancelled
    }
    public class Order : Entity
    {
        public User Customer { get; private set; }
        public DateTime OrderDate { get; private set; }
        public double TotalAmount { get; private set; }
        public OrderStatus Status { get; private set; }
        public List<OrderItem> Items { get; private set; }

        public Order() 
        {
            Customer = new User();
            OrderDate = DateTime.MinValue;
            TotalAmount = 0.0;
            Status = OrderStatus.Pending;
            Items = new List<OrderItem>();
        }
        public Order(User customer, DateTime orderDate, double totalAmount, OrderStatus status)
        {
            Customer = customer;
            OrderDate = orderDate;
            TotalAmount = totalAmount;
            Status = status;
            Items = new List<OrderItem>();
        }

        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
        }

    }
}
