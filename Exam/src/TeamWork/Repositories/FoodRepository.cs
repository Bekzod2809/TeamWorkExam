using Microsoft.EntityFrameworkCore;
using TeamWork.Data;
using TeamWork.Entities;

namespace TeamWork.Repositories
{
    public class FoodRepository : IFoodRepository
    {
        private readonly AppDbContext _context;

        public FoodRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Food>> GetAllAsync()
        {
            return await _context.Foods.ToListAsync();
        }

        public async Task<Food?> GetByIdAsync(long id)
        {
            return await _context.Foods.FindAsync(id);
        }

        public async Task AddAsync(Food food)
        {
            await _context.Foods.AddAsync(food);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Food food)
        {
            _context.Foods.Update(food);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(long id)
        {
            var food = await _context.Foods.FindAsync(id);
            if (food != null)
            {
                _context.Foods.Remove(food);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<Food>> GetByCategoryIdAsync(long categoryId)
        {
            return await _context.Foods
                .Where(f => f.CategoryId == categoryId)
                .ToListAsync();
        }
    }
}