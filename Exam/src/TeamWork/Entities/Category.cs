namespace TeamWork.Entities;

public class Category
{
    public long CategoryId { get; set; }
    public string Name { get; set; }
    public ICollection<Food> Foods { get; set; }
}
