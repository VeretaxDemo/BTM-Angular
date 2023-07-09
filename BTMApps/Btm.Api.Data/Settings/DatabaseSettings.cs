namespace Btm.Api.Data.Settings;

public class DatabaseSettings : IDatabaseSettings
{
    public string ConnectionString => CalculateConnectionString();
    public string ServerName { get; set; } = string.Empty;
    public string Port { get; set; } = string.Empty;
    public string DatabaseName { get; set; } = string.Empty;

    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;

    public string CalculateConnectionString()
    {
        var connectionString = $"Server={ServerName},{Port};Initial Catalog={DatabaseName};User Id={UserName};Password={Password};Encrypt=False;";
        return connectionString;
    }

}