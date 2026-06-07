using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain
{
    public class Report : Entity
    {

        public User GeneratedBy { get; private set; }
        public string Title { get; private set; }
        public string Content { get; private set; }
        public DateTime CreatedAt { get; private set; }

        public Report() 
        {
            GeneratedBy = new User();
            Title = string.Empty;
            Content = string.Empty;
            CreatedAt = DateTime.MinValue;
        }

        public Report(User generatedBy, string title, string content, DateTime createdAt)
        {
            GeneratedBy = generatedBy;
            Title = title;
            Content = content;
            CreatedAt = createdAt;
        }
    }
}
