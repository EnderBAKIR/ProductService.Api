using CoreLayer.DTOs;
using CoreLayer.Models;

namespace CoreLayer.Services
{
    public interface IProductService : IService<Product>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();


    }
}
