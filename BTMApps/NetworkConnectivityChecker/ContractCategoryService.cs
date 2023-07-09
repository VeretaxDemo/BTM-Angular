using Btm.Api.Data.Models.Contracts;
using Btm.Api.Data.Services;

namespace NetworkConnectivityChecker;

public class ContractCategoryService : IContractCategoryService
{

    private readonly AppDbContext _dbContext;
    public ContractCategoryService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public List<ContractCategory> GetAllContractCategories()
    {
        List<ContractCategory> contractCategories = _dbContext.ContractCategory.ToList();
        return contractCategories;
    }
}