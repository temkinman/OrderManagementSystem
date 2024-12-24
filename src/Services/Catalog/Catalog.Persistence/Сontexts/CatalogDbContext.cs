using Catalog.Application.Interfaces;
using Catalog.Domain.Entities;
using Catalog.Persistence.EntityTypeConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Catalog.Persistence.Contexts;

public class CatalogDbContext : DbContext, ICatalogDbContext
{
    public CatalogDbContext(DbContextOptions<CatalogDbContext> options) : base(options)
    { }

    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProductConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}