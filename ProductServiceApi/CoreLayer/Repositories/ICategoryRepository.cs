using CoreLayer.Models;

namespace CoreLayer.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {

        Task<Category> GetSingleCategoryByIdWithProductsAsync(int categoryId);
    }
}
