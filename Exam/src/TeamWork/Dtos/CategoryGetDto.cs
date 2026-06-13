namespace TeamWork.Dtos;

public class CategoryGetDto
{
    public long CategoryId { get; set; }
    public string Name { get; set; }

    public void UpdateEntity(CategoryUpdateDto dto)
    {
        throw new NotImplementedException();
    }

    public CategoryGetDto? ToGetDto()
    {
        throw new NotImplementedException();
    }
}
