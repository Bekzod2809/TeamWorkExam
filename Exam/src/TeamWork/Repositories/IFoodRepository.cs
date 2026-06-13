using TeamWork.Entities;

namespace TeamWork.Repositories
{
    public interface IFoodRepository
    {
        Task<IEnumerable<Food>> GetAllAsync();
        Task<IEnumerable<Food>> GetByCategoryIdAsync(long categoryId);
        Task<Food?> GetByIdAsync(long id); 
        Task AddAsync(Food food);
        Task UpdateAsync(Food food);
        Task DeleteAsync(long id);
    }
}