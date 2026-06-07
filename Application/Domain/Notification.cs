using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain
{
    public class Notification : Entity
    {
        public User Reciever { get; private set; }
        public string Message { get; private set; }
        public bool IsSeen { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Notification() 
        { 
            Reciever = new User();
            Message = string.Empty;
            IsSeen = false;
            CreatedAt = DateTime.MinValue;
        }

        public Notification(User reciever, string message, DateTime createdAt)
        {
            Reciever = reciever;
            Message = message;
            IsSeen = false;
            CreatedAt = createdAt;
        }

        public Notification(User reciever, string message,bool isSeen, DateTime createdAt)
        {
            Reciever = reciever;
            Message = message;
            IsSeen = isSeen;
            CreatedAt = createdAt;
        }

        public void MarkAsSeen()
        {
            IsSeen = true;
        }
    }
}
