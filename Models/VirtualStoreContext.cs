using Microsoft.EntityFrameworkCore;

namespace VirtualStoreApi.Models
{
    public class VirtualStoreContext : DbContext
    {
        public VirtualStoreContext(DbContextOptions<VirtualStoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<Category> Categories { get; set; } = null!;
        public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //due to mysql do not follow convention CamelCase or Pascalcase
            modelBuilder.Entity<Product>()
                .Property(p => p.CategoryId)
                .HasColumnName("category_id");
            
            modelBuilder.Entity<Product>()
                .HasOne<Category>()
                .WithMany()
                .HasForeignKey(p => p.CategoryId);

            modelBuilder.Entity<Order>()
                .Property(or => or.UserId)
                .HasColumnName("user_id");
            modelBuilder.Entity<Order>()
                .HasOne<User>()
                .WithMany()
                .HasForeignKey(o => o.UserId);
            
            modelBuilder.Entity<OrderDetail>().Property(od => od.UnitPrice)
                .HasColumnName("unit_price");
            modelBuilder.Entity<OrderDetail>().Property(od => od.OrderId)
                .HasColumnName("order_id");
            modelBuilder.Entity<OrderDetail>()
                .HasOne<Order>()
                .WithMany()
                .HasForeignKey(od => od.OrderId);
            
            modelBuilder.Entity<OrderDetail>().Property(od => od.ProductId)
                .HasColumnName("product_id");
            modelBuilder.Entity<OrderDetail>()
                .HasOne<Product>()
                .WithMany()
                .HasForeignKey(od => od.ProductId);
        }
    }
}