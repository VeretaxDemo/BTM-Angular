using Btm.Api.Data.Models.Contracts;
using Btm.Api.Data.Services;
using Btm.Api.Library.Data.Other.Context;

namespace Btm.Api.Library.Data.Other.Services;

[Obsolete("ContractCategoryService is being retired")]
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