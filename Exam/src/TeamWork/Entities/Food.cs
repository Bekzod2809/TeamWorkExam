namespace TeamWork.Entities;

public class Food
{
    public long FoodId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public bool IsAvailable { get; set; }
    public long CategoryId { get; set; }
    public Category Category { get; set; }
}
