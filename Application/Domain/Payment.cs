using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain
{
    public enum PaymentStatus
    {
        Pending,
        Completed,
        Failed,
        Refunded
    }
    public class Payment : Entity
    {
        public int OrderId { get; private set; }
        public decimal Amount { get; private set; }
        public DateTime Date { get; private set; }
        public PaymentStatus Status { get; private set; }
    }
}
