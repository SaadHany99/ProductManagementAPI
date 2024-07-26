using Microsoft.EntityFrameworkCore;
using ProductManagementAPI.Models;
using ProductManagementAPI.Models.Data;

namespace ProductManagementAPI.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext context;

        public ProductRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public async Task AddProduct(Product product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();
        }

        public async Task DeleteProduct(Product product)
        {
            if(product!=null)
            {
                context.Products.Remove(product);
                await context.SaveChangesAsync();
            }
        }

        public async Task<Product> GetProductById(int id)
        {
            return await context.Products.Include(p=>p.ProductCategories)
                .ThenInclude(pc=>pc.Category)
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Product>> GetProducts()
        {
            return await context.Products.Include(p=>p.ProductCategories)
                .ThenInclude(pc=>pc.Category)
                .ToListAsync();
        }

        public async Task UpdateProduct(Product product)
        {
            context.Entry(product).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }
    }
}
