using Btm.Api.Data.Models.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Btm.Api.Library.Data.EntityFrameworkCore.Context;

public class AppDbContext : DbContext
{
    public DbSet<ContractCategory> ContractCategory { get; set; }
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
