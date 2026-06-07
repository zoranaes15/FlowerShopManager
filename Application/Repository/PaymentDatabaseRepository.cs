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
    public class PaymentDatabaseRepository : CrudDatabaseRepository<Payment, FlowerShopManagerDbContext>, IPaymentRepository
    {
        public PaymentDatabaseRepository(FlowerShopManagerDbContext context) : base(context) {}

        public List<Payment> GetAllWithOrder()
        {
            return DbContext.Payments
                .AsNoTracking()
                .Include(p => p.Order)
                    .ThenInclude(o => o.Customer)
                .ToList();
        }
    }
}
