using TeamWork.Dtos;

namespace TeamWork.Services;

public interface ICategoryService
{
    Task<List<CategoryGetDto>> GetAllAsync();
    Task<CategoryGetDto?> GetByIdAsync(long id);
    Task<CategoryGetDto> CreateAsync(CategoryCreateDto dto);
    Task UpdateAsync(long id, CategoryUpdateDto dto);
    Task DeleteAsync(long id);
}