using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain
{
    public class Report : Entity
    {

        public int UserId { get; private set; }
        public string ReportName { get; private set; }
        public string ReportContet { get; private set; }
        public DateTime CreatedAt { get; private set; }
    }
}
