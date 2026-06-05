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

    }
}
