using System.Data.SqlClient;

string server = "localhost";
int port = 14333;
string ukey = "BTM_AdminOnlyUser";
string pwd = "rvb29gaqrU!G7CC6*v2gxUKfW";
string connectionString = $"Server={server},{port};Database=master;User Id={ukey};Password={pwd};";

try
{
    using (SqlConnection connection = new SqlConnection(connectionString))
    {
        connection.Open();
        Console.WriteLine("Connection successful!");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Connection failed: {ex.Message}");
}
