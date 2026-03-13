using WebBanHang_NGUYEN_VAN_THANH_2380602048.Models;

namespace WebBanHang_NGUYEN_VAN_THANH_2380602048.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(int id);
    }
}
