using Btm.Api.Data.Models.Contracts;
using Microsoft.EntityFrameworkCore;

namespace NetworkConnectivityChecker;

public class AppDbContext : DbContext
{
    public DbSet<ContractCategory> ContractCategory { get; set; }
    private readonly string _connectionString;

    public AppDbContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Configure the SQL Server connection
        optionsBuilder.UseSqlServer(_connectionString);
    }
}