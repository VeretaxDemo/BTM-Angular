using Btm.Api.Data.Models.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Btm.Api.Library.Data.Other.Context;

[Obsolete("ReadOnlyDbContext is being retired")]
public class ReadOnlyDbContext : Microsoft.EntityFrameworkCore.DbContext
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