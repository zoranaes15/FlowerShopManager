using Application.Domain;

namespace Application.Service.Interfaces
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int id);
        Product Create(Product product);
        Product Update(Product product);
        void Delete(int id);
        List<Product> GetLowStock(int threshold = 25);
    }
}
