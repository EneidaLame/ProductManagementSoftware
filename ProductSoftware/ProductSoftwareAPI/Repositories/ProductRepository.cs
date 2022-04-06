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

        public async Task<ProductCategory> GetCategory(int id)
        {
            var category = await productSoftwareDbContext.ProductCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        public async Task<Product> GetItem(int id)
        {
            var product = await productSoftwareDbContext.Products.FindAsync(id);
            return product;
        }

        public async Task<IEnumerable<Product>> GetItems()
        {
            var products = await this.productSoftwareDbContext.Products.ToListAsync();
            return products;
        }

        public async Task<IEnumerable<Product>> GetItemsByCategory(int id)
        {
             var products = await (from product in this.productSoftwareDbContext.Products
                                   where product.CategoryId == id
                                   select product).ToListAsync();
            return products;
        }
    }
}
