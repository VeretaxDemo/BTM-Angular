using Btm.Api.Library.Models.Contracts;

namespace Btm.Api.Web.DataAccess;

public interface IContractCategoryDataAccess
{
    List<ContractCategory> GetContractCategories();
}