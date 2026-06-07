using Application.Database;
using Application.Domain;
using Application.Repository;
using Application.Repository.Interfaces;
using Application.Service.Interfaces;

namespace Application.Service
{
    public class PaymentService : IPaymentService
    {
        private readonly IPaymentRepository _paymentRepository;

        public PaymentService()
        {
            _paymentRepository = new PaymentDatabaseRepository(AppDb.CreateContext());
        }

        public List<Payment> GetAll()
        {
            return _paymentRepository.GetAllWithOrder();
        }

        public Payment GetById(int id)
        {
            var payment = _paymentRepository.Get(id);
            if (payment == null)
                throw new Exception($"Plaćanje sa ID {id} nije pronađeno.");
            return payment;
        }

        public Payment Create(Payment payment)
        {
            return _paymentRepository.Create(payment);
        }

        public Payment Update(Payment payment)
        {
            return _paymentRepository.Update(payment);
        }

        public void Delete(int id)
        {
            _paymentRepository.Delete(id);
        }

        public Payment GetByOrderId(int orderId)
        {
            var payment = GetAll().FirstOrDefault(p => p.Order.Id == orderId);
            if (payment == null)
                throw new Exception($"Plaćanje za narudžbinu {orderId} nije pronađeno.");
            return payment;
        }
    }
}
