using TeamWork.Dtos;
using TeamWork.Entities;
using TeamWork.Mappings;
using TeamWork.Repositories;

namespace TeamWork.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<List<CategoryGetDto>> GetAllAsync()
    {
        var categories = await _categoryRepository.GetAllAsync();
        return categories.ToGetDtoList().ToList();
    }

    public async Task<CategoryGetDto?> GetByIdAsync(long id)
    {
        var category = await _categoryRepository.GetByIdAsync(id);
        if (category is null) return null;
        return category.ToGetDto();
    }

    public async Task<CategoryGetDto> CreateAsync(CategoryCreateDto dto)
    {
        var category = dto.ToEntity();
        await _categoryRepository.AddAsync(category);
        return category.ToGetDto();
    }

    public async Task UpdateAsync(long id, CategoryUpdateDto dto)
    {
        Category? category = await _categoryRepository.GetByIdAsync(id);
        if (category is null) return;

        category.UpdateEntity(dto);
        await _categoryRepository.UpdateAsync(category);
    }

    public async Task DeleteAsync(long id)
    {
        await _categoryRepository.DeleteAsync(id);
    }
}