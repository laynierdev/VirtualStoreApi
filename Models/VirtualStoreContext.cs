using Microsoft.EntityFrameworkCore;

namespace VirtualStoreApi.Models;

public class VirtualStoreContext : DbContext
{
    public VirtualStoreContext(DbContextOptions<VirtualStoreContext> options):base(options)
    {
        
    }
    
    public DbSet<Product> Products { get; set; } = null!;
    
}