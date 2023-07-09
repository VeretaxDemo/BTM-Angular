using Btm.Api.Data.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Btm.Api.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContractCategoryController : ControllerBase
    {
        private readonly IContractCategoryService _contractCategoryService;

        public ContractCategoryController(IContractCategoryService contractCategoryService)
        {
            _contractCategoryService = contractCategoryService;
        }


        [HttpGet]
        //[Route("api/contractcategories")]
        public IActionResult GetAllContractCategories()
        {
            var contractCategories = _contractCategoryService.GetAllContractCategories();
            return Ok(contractCategories);
        }

        //[HttpGet]
        //public async Task<IActionResult> GetContractCategories()
        //{
        //    var contractCategories = await _contractCategoryService.GetContractCategories();
        //    return Ok(contractCategories);
        //}

        //// GET: api/<ContractCategoryController>
        //[HttpGet]
        //public IEnumerable<ContractCategory> Get()
        //{
        //    ContractCategoryService service = new ContractCategoryService()
        //    return new string[] { "value1", "value2" };
        //}

        //// GET api/<ContractCategoryController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ContractCategoryController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ContractCategoryController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ContractCategoryController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
