using Microsoft.AspNetCore.Mvc;
using TeamWork.Dtos;
using TeamWork.Services;

namespace TeamWork.Controllers
{
    [ApiController]
    [Route("api/food-controller")]
    public class FoodController : ControllerBase
    {
        private readonly IFoodService _foodService;

        public FoodController(IFoodService foodService)
        {
            _foodService = foodService;
        }

        [HttpGet]
        public async Task<IEnumerable<FoodGetDto>> GetAll()
        {
            return await _foodService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<FoodGetDto?> GetById(long id)
        {
            return await _foodService.GetByIdAsync(id);
        }

        [HttpPost]
        public async Task Create(FoodCreateDto dto)
        {
            await _foodService.AddAsync(dto);
        }

        [HttpPut("{id}")]
        public async Task Update(long id, FoodUpdateDto dto)
        {
            await _foodService.UpdateAsync(id, dto);
        }

        [HttpDelete("{id}")]
        public async Task Delete(long id)
        {
            await _foodService.DeleteAsync(id);
        }
        [HttpGet("category/{categoryId}")]
        public async Task<IEnumerable<FoodGetDto>> GetByCategoryId(long categoryId)
        {
            return await _foodService.GetByCategoryIdAsync(categoryId);
        }
    }
    
}