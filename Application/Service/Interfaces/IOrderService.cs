using Application.Domain;

namespace Application.Service.Interfaces
{
    public interface IOrderService
    {
        List<Order> GetAll();
        Order GetById(int id);
        Order Create(Order order);
        Order Update(Order order);
        void Delete(int id);
        List<Order> GetByCustomerId(int customerId);
        List<Order> GetByStatus(OrderStatus status);
    }
}
