using TeamWork.Dtos;
using TeamWork.Mappings;
using TeamWork.Repositories;
using TeamWork.Entities;

namespace TeamWork.Services
{
    public class FoodService : IFoodService
    {
        private readonly IFoodRepository _repository;

        public FoodService(IFoodRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<FoodGetDto>> GetAllAsync()
        {
            var foods = await _repository.GetAllAsync();
            return foods.ToGetDtoList();
        }

        public async Task<FoodGetDto?> GetByIdAsync(long id)
        {
            var food = await _repository.GetByIdAsync(id);
            return food?.ToGetDto();
        }

        public async Task AddAsync(FoodCreateDto foodDto)
        {
            var food = foodDto.ToEntity();
            await _repository.AddAsync(food);
        }

        public async Task UpdateAsync(long id, FoodUpdateDto foodDto)
        {
            var existingFood = await _repository.GetByIdAsync(id);
            if (existingFood != null)
            {
                existingFood.UpdateEntity(foodDto);
                await _repository.UpdateAsync(existingFood);
            }
            else
            {
                throw new Exception($"Food ID {id} topilmadi.");
            }
        }

        public async Task DeleteAsync(long id) => await _repository.DeleteAsync(id);
    }
}