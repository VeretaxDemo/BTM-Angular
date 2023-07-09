namespace Btm.Api.Library.Data.Other.DbContext;

// There appear to be two different AppDbContext in this project
[Obsolete("AppDbContext is being retired")]
public class AppDbContext : Microsoft.EntityFrameworkCore.DbContext
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