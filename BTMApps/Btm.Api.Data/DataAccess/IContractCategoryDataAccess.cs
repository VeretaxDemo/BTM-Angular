using Btm.Api.Data.Models.Contracts;

namespace Btm.Api.Data.DataAccess;

public interface IContractCategoryDataAccess
{
    //Task<IEnumerable<ContractCategory>> GetContractCategories();
    Task<List<ContractCategory>> GetContractCategories();
}