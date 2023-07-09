using Btm.Api.Data.Models.Contracts;
using Btm.Api.Data.Settings;
using Btm.Api.Library.Data.Other.Connections;
using Btm.Api.Library.Data.Other.Context;
using Microsoft.Extensions.Logging;

namespace Btm.Api.Library.Data.Other.DataAccess;

[Obsolete("ContractCategoryDataAccess is being retired")]
public class ContractCategoryDataAccess : IContractCategoryDataAccess
{
    private readonly AppDbContext _dbContext;
    //private readonly DbContext _dbContext;
    private readonly IDataConnection _dataConnection;
    private readonly ILogger<ContractCategoryDataAccess> _logger;
    private readonly DatabaseSettings _databaseSettings;

    //public ContractCategoryDataAccess(IDataConnection dataConnection, ILogger<ContractCategoryDataAccess> logger, DatabaseSettings databaseSettings)
    //{
    //    _databaseSettings = databaseSettings;
    //    _dataConnection = dataConnection;
    //    _logger = logger;
    //}

    public ContractCategoryDataAccess(AppDbContext dbContext, ILogger<ContractCategoryDataAccess> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public async Task<List<ContractCategory>> GetContractCategories()
    {
        return await _dbContext.ContractCategory.ToListAsync();
    }

    //public async Task<IEnumerable<ContractCategory>> GetContractCategories()
    //{
    //    try
    //    {
    //        using (var connection = new SqlConnection(_databaseSettings.AdminOnlyConnection))
    //        {
    //            var parameters = new { /* Add any required stored procedure parameters */ };
    //            var results = await connection.QueryAsync<ContractCategory>("[dbo].[sp_ContractCategory_Get_All]", parameters, commandType: CommandType.StoredProcedure);
    //            return results.ToList();
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        _logger.LogError(ex, "Failed to retrieve ContractCategories from the database.");
    //        return new List<ContractCategory>();
    //    }
    //}
}