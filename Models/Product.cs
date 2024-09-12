namespace VirtualStoreApi.Models;

public class Product
{
    public long Id { get; set; }
    public string? Name { get; set; }
    public float Price { get; set; }
    public string? Description { get; set; }
    public bool InStock { get; set; }

    public Product(long id, string? name, float price, string? description, bool inStock)
    {
        this.Id = id;
        this.Name = name;
        this.Price = price;
        this.Description = description;
    }
}