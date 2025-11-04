using Microsoft.EntityFrameworkCore;
using InventoryManagement.Models;


namespace InventoryManagement.Data;

public class AppDbContext: DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<User> Users { get; set; }
    public DbSet<Inventory> Inventories { get; set; }
    
    public DbSet<FullInventory> FullInventories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Inventory>()
            .HasKey(i=> new{i.UserId,i.InventoryId});
        
        modelBuilder.Entity<Inventory>()
            .HasOne<User>()
            .WithMany()
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        
        modelBuilder.Entity<FullInventory>()
            .HasKey(fi=> new{fi.UserId,fi.InventoryId});
        
        modelBuilder.Entity<FullInventory>()
            .HasOne<User>()
            .WithMany()
            .HasForeignKey(i => i.UserId)
            .OnDelete(DeleteBehavior.Cascade);
        
        
        
        base.OnModelCreating(modelBuilder);
    }
}