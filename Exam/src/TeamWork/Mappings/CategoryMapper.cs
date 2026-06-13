using TeamWork.Dtos;
using TeamWork.Entities;

namespace TeamWork.Mappings;

public static class CategoryMapper
{
    public static CategoryGetDto ToGetDto(this Category category)
    {
        return new CategoryGetDto
        {
            CategoryId = category.CategoryId,
            Name = category.Name
        };
    }

    public static Category ToEntity(this CategoryCreateDto dto)
    {
        return new Category
        {
            Name = dto.Name
        };
    }

    public static void UpdateEntity(this Category category, CategoryUpdateDto dto)
    {
        category.Name = dto.Name;
    }

    public static IEnumerable<CategoryGetDto> ToGetDtoList(this IEnumerable<Category> categories)
    {
        return categories.Select(c => c.ToGetDto());
    }
}