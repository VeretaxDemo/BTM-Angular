namespace Btm.Api.Library.Data.Other.Connections;

[Obsolete("AdminOnlyDataConnection is being retired")]
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