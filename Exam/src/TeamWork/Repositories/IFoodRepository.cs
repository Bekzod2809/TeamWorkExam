using TeamWork.Entities;

namespace TeamWork.Repositories
{
    public interface IFoodRepository
    {
        Task<IEnumerable<Food>> GetAllAsync();
        Task<Food?> GetByIdAsync(long id); 
        Task AddAsync(Food food);
        Task UpdateAsync(Food food);
        Task DeleteAsync(long id);
    }
}