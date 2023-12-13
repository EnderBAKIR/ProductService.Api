using CoreLayer.DTOs;
using CoreLayer.Models;
using CoreLayer.Services;

namespace CoreLayer.Services
{
    public interface ICategoryService : IService<Category>
    {
        public Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int categoryId);

    }
}
