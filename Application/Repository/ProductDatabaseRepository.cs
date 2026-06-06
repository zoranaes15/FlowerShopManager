using Application.Database;
using Application.Domain;
using Application.Repository.Base;
using Application.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class ProductDatabaseRepository : CrudDatabaseRepository<Product, FlowerShopManagerDbContext>, IProductRepository
    {
        public ProductDatabaseRepository(FlowerShopManagerDbContext context) : base(context) {}
    }
}
