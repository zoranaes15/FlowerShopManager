using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Domain
{
    public class Product : Entity
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public double Price { get; private set; }
        public int Stock { get; private set; }

        public Product() 
        {
                Name = string.Empty;
                Description = string.Empty;
                Price = 0.0;
                Stock = 0;
        }
        public Product(int id, string name, string description, int stock, double price)
        {
            Id = id;
            Name = name;
            Description = description;
            Stock = stock;
            Price = price;
        }

        public Product(string name, string description, int stock, double price)
        {
            Name = name;
            Description = description;
            Stock = stock;
            Price = price;
        }
    }
}
