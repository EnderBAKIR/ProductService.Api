using CoreLayer.Models;

namespace CoreLayer.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetProductsWitCategory();


    }
}
