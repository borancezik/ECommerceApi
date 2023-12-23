using ECommerceApi.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ECommerceApi.Persistence.Context;

public class AppDbContext : DbContext
{
    public AppDbContext() { }

    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    public DbSet<BrandEntity> Brands { get; set; }  
    public DbSet<DetailEntity> Details { get; set; }  
    public DbSet<CategoryEntity> Categories { get; set; }  
    public DbSet<ProductEntity> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
