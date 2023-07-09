using Btm.Api.Data.Models.Contracts;
using Btm.Api.Data.Services;
using Microsoft.EntityFrameworkCore;
using NetworkConnectivityChecker;

string server = "localhost";
int port = 14333;
string ukey = "BTM_Angular_LocalDev_User";
string pwd = "kDsiBhV42P3G4Bs7*CCR_uCPJ";
string dbase = "btm_angular";
string connectionString = $"Server={server},{port};Initial Catalog={dbase};User Id={ukey};Password={pwd};Encrypt=False;";

//try
//{
//    using (SqlConnection connection = new SqlConnection(connectionString))
//    {
//        connection.Open();
//        Console.WriteLine("Connection successful!");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Connection failed: {ex.Message}");
//}

try
{
    using (var dbContext = new AppDbContext(connectionString))
    {
        dbContext.Database.OpenConnection();

        Console.WriteLine("Connection successful!");

        var service = new NetworkConnectivityChecker.ContractCategoryService(dbContext);

        var contractCategories = service.GetAllContractCategories();

        Console.WriteLine("Contract Categories");
        foreach (var contractCategory in contractCategories)
        {

            string msg = $"Id: { contractCategory.Id } Title: {contractCategory.Title} Description: {contractCategory.Description} SpecialConsiderations:{contractCategory.SpecialConsiderations}";

            Console.WriteLine(msg);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Connection failed: {ex.Message}");
}
