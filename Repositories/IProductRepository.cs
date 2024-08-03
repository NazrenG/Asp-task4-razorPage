using Asp_Razor_Page.Entities;

namespace Asp_Razor_Page.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetProducts();
        Task<Product?> GetProductById(int id);

        Task Create(Product product);
        Task Update(Product product);
        Task Delete(Product product);

    }
}
