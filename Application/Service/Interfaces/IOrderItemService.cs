using Application.Domain;

namespace Application.Service.Interfaces
{
    public interface IOrderItemService
    {
        List<OrderItem> GetAll();
        OrderItem GetById(int id);
        OrderItem Create(OrderItem orderItem);
        OrderItem Update(OrderItem orderItem);
        void Delete(int id);
        List<OrderItem> GetByOrderId(int orderId);
    }
}
