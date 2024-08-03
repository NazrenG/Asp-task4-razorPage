using Asp_Razor_Page.Entities;

namespace Asp_Razor_Page.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetProductsAsync();
        Task<Product?> GetProductByIdAsync(int id);

        Task Create(Product product);
        Task Update(Product product);
        Task Delete(Product product);
    }
}
