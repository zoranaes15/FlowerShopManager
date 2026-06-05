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

    }
}
