using Btm.Api.Data.Connections;
using Btm.Api.Data.Models.Contracts;
using Microsoft.EntityFrameworkCore;

namespace Btm.Api.Data.Connections;

public class DataConnection : IDataConnection
{
    private readonly string _connectionString;
    private readonly IDatabaseSettings _databaseSettings;
    public DataConnection(IDatabaseSettings databaseSettings)
    {
        _databaseSettings = databaseSettings;
        _connectionString = databaseSettings.CalculateConnectionString();
    }

    // Implement any additional data access methods here
    public string ConnectionString => _connectionString;
}