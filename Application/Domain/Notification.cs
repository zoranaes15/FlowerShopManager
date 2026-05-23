using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain
{
    public class Notification : Entity
    {
        public int UserId { get; private set; }
        public string Message { get; private set; }
        public bool IsItRead { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
