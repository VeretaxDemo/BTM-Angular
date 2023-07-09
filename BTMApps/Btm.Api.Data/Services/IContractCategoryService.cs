using Btm.Api.Data.Models.Contracts;

namespace Btm.Api.Data.Services;

public interface IContractCategoryService
{
    //Task<IEnumerable<ContractCategory>> GetContractCategories();
    List<ContractCategory> GetAllContractCategories();
}