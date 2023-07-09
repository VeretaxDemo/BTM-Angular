using Btm.Api.Data.Context;
using Btm.Api.Data.DataAccess;
using Btm.Api.Data.Models.Contracts;

namespace Btm.Api.Data.Services
{
    public class ContractCategoryService : IContractCategoryService
    {

        private readonly AppDbContext _dbContext;
        public ContractCategoryService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ContractCategory> GetAllContractCategories()
        {
            List<ContractCategory> contractCategories = _dbContext.ContractCategories.ToList();
            return contractCategories;
        }

        //private readonly IContractCategoryDataAccess _contractCategoryDataAccess;

        //public ContractCategoryService(IContractCategoryDataAccess contractCategoryDataAccess)
        //{
        //    _contractCategoryDataAccess = contractCategoryDataAccess;
        //}

        //public async Task<IEnumerable<ContractCategory>> GetContractCategories()
        //{
        //    return await _contractCategoryDataAccess.GetContractCategories();
        //}
    }
}
