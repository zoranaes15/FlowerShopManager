using Application.Repository.Base;
using Application.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Repository.Interfaces
{
    public interface IPaymentRepository : ICrudRepository<Payment>
    {
        List<Payment> GetAllWithOrder();
    }
}
