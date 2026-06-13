namespace TeamWork.Dtos;

public class FoodCreateDto
{
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public long CategoryId { get; set; }
}
