using Btm.Api.Data.Models.Contracts;

namespace Btm.Api.Library.Data.Other.DataAccess;

[Obsolete("IContractCategoryDataAccess is being retired")]
public interface IContractCategoryDataAccess
{
    //Task<IEnumerable<ContractCategory>> GetContractCategories();
    Task<List<ContractCategory>> GetContractCategories();
}