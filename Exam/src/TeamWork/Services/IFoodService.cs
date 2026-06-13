using TeamWork.Dtos;

namespace TeamWork.Services
{
    public interface IFoodService
    {
        Task<IEnumerable<FoodGetDto>> GetAllAsync();
        Task<FoodGetDto?> GetByIdAsync(long id);
        Task AddAsync(FoodCreateDto foodDto);
        Task UpdateAsync(long id, FoodUpdateDto foodDto);
        Task DeleteAsync(long id);
    }
}