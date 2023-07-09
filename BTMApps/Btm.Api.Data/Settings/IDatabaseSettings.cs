namespace Btm.Api.Library.Data.Other.Connections;

public interface IDatabaseSettings
{
    string ConnectionString { get; }
    string ServerName { get; set; }
    string Port { get; set; }
    string DatabaseName { get; set; }
    string UserName { get; set; }
    string Password { get; set; }
    string CalculateConnectionString();
}