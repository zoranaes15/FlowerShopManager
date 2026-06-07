using Application.Database;
using Application.Domain;
using Application.Repository;
using Application.Repository.Interfaces;
using Application.Service.Interfaces;

namespace Application.Service
{
    public class OrderItemService : IOrderItemService
    {
        private readonly IOrderItemRepository _orderItemRepository;

        public OrderItemService()
        {
            _orderItemRepository = new OrderItemDatabaseRepository(AppDb.CreateContext());
        }

        public List<OrderItem> GetAll()
        {
            return _orderItemRepository.GetAll().Cast<OrderItem>().ToList();
        }

        public OrderItem GetById(int id)
        {
            var item = _orderItemRepository.Get(id);
            if (item == null)
                throw new Exception($"Stavka sa ID {id} nije pronađena.");
            return item;
        }

        public OrderItem Create(OrderItem orderItem)
        {
            return _orderItemRepository.Create(orderItem);
        }

        public OrderItem Update(OrderItem orderItem)
        {
            return _orderItemRepository.Update(orderItem);
        }

        public void Delete(int id)
        {
            _orderItemRepository.Delete(id);
        }

        public List<OrderItem> GetByOrderId(int orderId)
        {
            return GetAll().Where(i => i.Order.Id == orderId).ToList();
        }
    }
}
