namespace Btm.Api.Web.Connections;

public class DatabaseSettings
{
    public string ConnectionString { get; set; } = string.Empty;
    public string ServerName { get; set; } = string.Empty;
    public string Port { get; set; } = string.Empty;
    public string DatabaseName { get; set; } = string.Empty;

    public string ReadOnlyConnection => CalculateConnectionString(ReadOnlyUser);
    public string AdminOnlyConnection => CalculateConnectionString(AdminOnlyUser);

    public ReadOnlyUserSettings ReadOnlyUser { get; set; } = new ReadOnlyUserSettings();
    public AdminOnlyUserSettings AdminOnlyUser { get; set; } = new AdminOnlyUserSettings();
    public interface IUserSettings
    {
        string UserName { get; set; }
        string Password { get; set; }
    }

    public class ReadOnlyUserSettings : IUserSettings
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public class AdminOnlyUserSettings : IUserSettings
    {
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }

    public string CalculateConnectionString(IUserSettings user)
    {
        ConnectionString = $"Server={ServerName},{Port};Database={DatabaseName};User Id={user.UserName};Password={user.Password};";
        return ConnectionString;
    }
}