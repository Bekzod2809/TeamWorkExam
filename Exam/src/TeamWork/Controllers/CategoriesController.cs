using Microsoft.AspNetCore.Mvc;
using TeamWork.Dtos;
using TeamWork.Mappings;
using TeamWork.Repositories;

namespace TeamWork.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CategoriesController : ControllerBase
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoriesController(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var categories = await _categoryRepository.GetAllAsync();
        return Ok(categories.ToGetDtoList());
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CategoryCreateDto dto)
    {
        var category = dto.ToEntity();
        await _categoryRepository.AddAsync(category);
        return Ok(category.ToGetDto());
    }
}