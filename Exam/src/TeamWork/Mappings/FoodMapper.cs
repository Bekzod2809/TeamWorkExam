using TeamWork.Dtos;
using TeamWork.Entities;

namespace TeamWork.Mappings;

public static class FoodMapper
{
    public static FoodGetDto ToGetDto(this Food food)
    {
        return new FoodGetDto
        {
            FoodId = food.FoodId,
            Name = food.Name,
            Description = food.Description,
            Price = food.Price,
            IsAvailable = food.IsAvailable,
            CategoryId = food.CategoryId
        };
    }

    public static Food ToEntity(this FoodCreateDto dto)
    {
        return new Food
        {
            Name = dto.Name,
            Description = dto.Description,
            Price = dto.Price,
            IsAvailable = dto.IsAvailable,
            CategoryId = dto.CategoryId
        };
    }

    public static void UpdateEntity(this Food food, FoodUpdateDto dto)
    {
        food.Name = dto.Name;
        food.Description = dto.Description;
        food.Price = dto.Price;
        food.IsAvailable = dto.IsAvailable;
        food.CategoryId = dto.CategoryId;
    }

    public static IEnumerable<FoodGetDto> ToGetDtoList(this IEnumerable<Food> foods)
    {
        return foods.Select(f => f.ToGetDto());
    }
}