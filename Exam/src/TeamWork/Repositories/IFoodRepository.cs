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
        Task<IEnumerable<Food>> GetAvailableAsync();
        Task<IEnumerable<Food>> SearchByNameAsync(string name);
    }
}