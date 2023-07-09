namespace Btm.Api.Library.Data.Other.Connections;


[Obsolete("IDataConnection is being retired")]
public interface IDataConnection
{
    // Define your data access methods here
    string ConnectionString { get; }
}