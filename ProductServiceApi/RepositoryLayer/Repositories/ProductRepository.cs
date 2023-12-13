using Microsoft.EntityFrameworkCore;
using CoreLayer;
using CoreLayer.Repositories;
using CoreLayer.Models;
using RepositoryLayer;

namespace RepositoryLayer.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsWitCategory()
        {

            return await _context.Products.Include(x => x.Category).ToListAsync();
        }
    }
}
