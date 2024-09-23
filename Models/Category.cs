namespace VirtualStoreApi.Models;

public class Category
{
    public int Id { get; set; }

    public string? Name { get; set; }
    public string? Description { get; set; }

    

    

    public Category(int id, string? name, string? description)
    {
        (Id, Name, Description) = (id, name, description);
    }
}