using Microsoft.EntityFrameworkCore;
using ProductSoftwareAPI.Data;
using ProductSoftwareAPI.Entities;
using ProductSoftwareAPI.Repositories.Contracts;

namespace ProductSoftwareAPI.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductSoftwareDbContext productSoftwareDbContext;

        public ProductRepository(ProductSoftwareDbContext productSoftwareDbContext)
        {
            this.productSoftwareDbContext = productSoftwareDbContext;
        }
        public async Task<IEnumerable<ProductCategory>> GetCategories()
        {
            var categories = await this.productSoftwareDbContext.ProductCategories.ToListAsync();
            return categories;
        }

        public Task<ProductCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.productSoftwareDbContext.Products.ToListAsync();
            return products;
        }
    }
}
