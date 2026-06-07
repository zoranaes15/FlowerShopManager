using Application.Database;
using Application.Domain;
using Application.Repository.Base;
using Application.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository
{
    public class OrderDatabaseRepository : CrudDatabaseRepository<Order, FlowerShopManagerDbContext>, IOrderRepository
    {
        public OrderDatabaseRepository(FlowerShopManagerDbContext context) : base(context) { }

        public List<Order> GetAllWithCustomerAndItems()
        {
            return DbContext.Orders
                      .AsNoTracking()
                      .Include(o => o.Customer)
                      .Include(o => o.Items)
                        .ThenInclude(i => i.Product)
                      .ToList();
        }

        public Order? GetWithCustomerAndItems(int id)
        {
            return DbContext.Orders
                      .AsNoTracking()
                      .Include(o => o.Customer)
                      .Include(o => o.Items)
                        .ThenInclude(i => i.Product)
                      .FirstOrDefault(o => o.Id == id);
        }
    }
}
