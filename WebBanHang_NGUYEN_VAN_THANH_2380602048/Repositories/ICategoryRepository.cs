using WebBanHang_NGUYEN_VAN_THANH_2380602048.Models;

namespace WebBanHang_NGUYEN_VAN_THANH_2380602048.Repositories
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task AddAsync(Category category);
        Task UpdateAsync(Category category);
        Task DeleteAsync(int id);
    }
}
