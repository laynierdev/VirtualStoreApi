namespace VirtualStoreApi.Models;

public class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }
    public string? Description { get; set; }
    public ICollection<Product> Products { get; set; }
    

    

    public Category(int id, string? name, string? description, ICollection<Product> products)
    {
        Products = products;
        (Id, Name, Description) = (id, name, description);
    }
    public Category()
    {
        Products = new List<Product>();
    }
}