using Application.Database;
using Application.Domain;
using Application.Repository;
using Application.Repository.Interfaces;
using Application.Service.Interfaces;

namespace Application.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService()
        {
            _productRepository = new ProductDatabaseRepository(AppDb.CreateContext());
        }

        public List<Product> GetAll()
        {
            return _productRepository.GetAll().Cast<Product>().ToList();
        }

        public Product GetById(int id)
        {
            var product = _productRepository.Get(id);
            if (product == null)
                throw new Exception($"Proizvod sa ID {id} nije pronađen.");
            return product;
        }

        public Product Create(Product product)
        {
            return _productRepository.Create(product);
        }

        public Product Update(Product product)
        {
            return _productRepository.Update(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public List<Product> GetLowStock(int threshold = 25)
        {
            return GetAll().Where(p => p.Stock < threshold).ToList();
        }
    }
}
