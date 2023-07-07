using Btm.Api.Library.Models.Contracts;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace Btm.Api.Web.DataAccess;

public class ContractCategoryDataAccess : IContractCategoryDataAccess
{
    private readonly DbContext _dbContext;
    private readonly ILogger<ContractCategoryDataAccess> _logger;

    public ContractCategoryDataAccess(DbContext dbContext, ILogger<ContractCategoryDataAccess> logger)
    {
        _dbContext = dbContext;
        _logger = logger;
    }

    public List<ContractCategory> GetContractCategories()
    {
        try
        {
            return _dbContext.Set<ContractCategory>().ToList();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Failed to retrieve ContractCategories from the database.");
            return new List<ContractCategory>();
        }
    }
}