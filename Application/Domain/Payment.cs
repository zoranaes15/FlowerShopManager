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
        public Order Order { get; private set; }
        public double Amount { get; private set; }
        public DateTime Date { get; private set; }
        public PaymentStatus Status { get; private set; }

        public Payment() 
        {
            Order = new Order();
            Amount = 0.0;
            Date = DateTime.MinValue;
            Status = PaymentStatus.Pending;
        }

        public Payment(Order order, double amount, DateTime date, PaymentStatus status)
        {
            Order = order;
            Amount = amount;
            Date = date;
            Status = status;
        }

        public void UpdateStatus(PaymentStatus newStatus)
        {
            Status = newStatus;
        }
    }
}
