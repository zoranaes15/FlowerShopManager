using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain
{
    public enum OrderStatus { 
        pending,
        processing,
        completed,
        cancelled
    }
    public class Order : Entity
    {
        public int CustomerId { get; private set; }
        public DateTime OrderDate { get; private set; }
        public decimal TotalAmount { get; private set; }
        public OrderStatus Status { get; private set; }

    }
}
