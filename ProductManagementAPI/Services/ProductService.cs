using ProductManagementAPI.Models;
using ProductManagementAPI.Repository;

namespace ProductManagementAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }
        public async Task AddProduct(Product product)
        {
            await repository.AddProduct(product);
        }

        public async Task DeleteProduct(Product product)
        {
            await repository.DeleteProduct(product);
        }

        public async Task<Product> GetProductById(int id)
        {
            return await repository.GetProductById(id);
        }

        public async Task<List<Product>> GetProducts()
        {
            return await repository.GetProducts();
        }

        public async Task UpdateProduct(Product product)
        {
            await repository.UpdateProduct(product);
        }
    }
}
