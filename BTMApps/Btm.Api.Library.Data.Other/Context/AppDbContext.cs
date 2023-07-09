using Btm.Api.Data.Models.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Btm.Api.Library.Data.Other.Context;

// There appear to be two different AppDbContext in this project
[Obsolete("AppDbContext is being retired")]
public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
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
