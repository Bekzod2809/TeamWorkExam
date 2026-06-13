using TeamWork.Dtos;
using TeamWork.Entities;

namespace TeamWork.Repositories;

public interface ICategoryRepository
{
    Task<List<Category>> GetAllAsync();
    Task<Category?> GetByIdAsync(long id);
    Task AddAsync(Category category);
    Task UpdateAsync(Category category);
    Task DeleteAsync(long id);
}
