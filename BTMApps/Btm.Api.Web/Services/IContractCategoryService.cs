using Btm.Api.Library.Models.Contracts;

namespace Btm.Api.Services;

public interface IContractCategoryService
{
    List<ContractCategory> GetContractCategories();
}