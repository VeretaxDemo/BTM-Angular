using Btm.Api.Data.Models.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Btm.Api.Data.Context;

public class ReadOnlyDbContext : DbContext
{
    public ReadOnlyDbContext(DbContextOptions<ReadOnlyDbContext> options) : base(options)
    {
    }

    // Define your entity DbSet properties here

    // Example:
    // public DbSet<YourEntity> YourEntities { get; set; }
    public DbSet<ContractCategory> ContractCategories { get; set; }
    public DbSet<ContractType> ContractTypes { get; set; }


}