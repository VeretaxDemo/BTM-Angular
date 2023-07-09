using Btm.Api.Data.Models.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Btm.Api.Data.Connections;

public class AdminOnlyDataConnection : IDataConnection
{
    private readonly string _connectionString;

    public AdminOnlyDataConnection(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Implement any additional data access methods here
    public string ConnectionString => _connectionString;
}