using Btm.Api.Library.Models.Contracts;
using Btm.Api.Web.Connections;
using Btm.Api.Web.DataAccess;
using System.Data;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;



namespace Btm.Api.Services
{
    public class ContractCategoryService : IContractCategoryService
    {
        private readonly IContractCategoryDataAccess _contractCategoryDataAccess;

        public ContractCategoryService(IContractCategoryDataAccess contractCategoryDataAccess)
        {
            _contractCategoryDataAccess = contractCategoryDataAccess;
        }

        public List<ContractCategory> GetContractCategories()
        {
            return _contractCategoryDataAccess.GetContractCategories();
        }
    }
}
