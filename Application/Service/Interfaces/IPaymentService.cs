using Application.Domain;

namespace Application.Service.Interfaces
{
    public interface IPaymentService
    {
        List<Payment> GetAll();
        Payment GetById(int id);
        Payment Create(Payment payment);
        Payment Update(Payment payment);
        void Delete(int id);
        Payment GetByOrderId(int orderId);
    }
}
