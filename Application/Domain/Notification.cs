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
    }
}
