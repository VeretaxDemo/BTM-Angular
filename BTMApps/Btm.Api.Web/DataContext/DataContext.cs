namespace Btm.Api.Web.DataContext;

public interface IDataContext
{
    // Define your data access methods here
}

public class ReadOnlyDataContext : IDataContext
{
    private readonly string _connectionString;

    public ReadOnlyDataContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Implement your data access methods here
}

public class AdminDataContext : IDataContext
{
    private readonly string _connectionString;

    public AdminDataContext(string connectionString)
    {
        _connectionString = connectionString;
    }

    // Implement your data access methods here
}