using Application.Database;
using Application.Domain;
using Application.Repository;
using Application.Repository.Interfaces;
using Application.Service.Interfaces;

namespace Application.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderDatabaseRepository(AppDb.CreateContext());
        }

        public List<Order> GetAll()
        {
            return _orderRepository.GetAllWithCustomerAndItems();
        }

        public Order GetById(int id)
        {
            var order = _orderRepository.GetWithCustomerAndItems(id);
            if (order == null)
                throw new Exception($"Narudžbina sa ID {id} nije pronađena.");
            return order;
        }

        public Order Create(Order order)
        {
            return _orderRepository.Create(order);
        }

        public Order Update(Order order)
        {
            return _orderRepository.Update(order);
        }

        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }

        public List<Order> GetByCustomerId(int customerId)
        {
            return GetAll().Where(o => o.Customer.Id == customerId).ToList();
        }

        public List<Order> GetByStatus(OrderStatus status)
        {
            return GetAll().Where(o => o.Status == status).ToList();
        }
    }
}
