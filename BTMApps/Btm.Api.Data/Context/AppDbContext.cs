using Btm.Api.Data.Models.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Btm.Api.Data.Context;

public class AppDbContext : DbContext
{
    public DbSet<ContractCategory> ContractCategories { get; set; }
    public DbSet<ContractType> ContractTypes { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure your entity mappings or relationships here
        // Example: modelBuilder.Entity<ContractCategory>().HasKey(c => c.Id);

        base.OnModelCreating(modelBuilder);
    }
}
