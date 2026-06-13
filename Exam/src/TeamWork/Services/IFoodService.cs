using TeamWork.Dtos;

namespace TeamWork.Services
{
    public interface IFoodService
    {
        Task<IEnumerable<FoodGetDto>> GetAllAsync();
        Task<FoodGetDto?> GetByIdAsync(long id);
        Task<IEnumerable<FoodGetDto>> GetByCategoryIdAsync(long categoryId);
        Task AddAsync(FoodCreateDto foodDto);
        Task UpdateAsync(long id, FoodUpdateDto foodDto);
        Task DeleteAsync(long id);
        Task<IEnumerable<FoodGetDto>> GetAvailableAsync();
        Task<IEnumerable<FoodGetDto>> SearchByNameAsync(string name);
    }
}