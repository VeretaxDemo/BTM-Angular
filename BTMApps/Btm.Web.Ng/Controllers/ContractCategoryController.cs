using Btm.Api.Library.DataAccess;
using Btm.Api.Library.Models.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Btm.Web.Ng.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContractCategoryController : ControllerBase
{
    private readonly ReadOnlyDbContext _dbContext;

    public ContractCategoryController(ReadOnlyDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        List<ContractCategory> contractCategories = await _dbContext.ContractCategories.ToListAsync();

        return Ok(contractCategories);
    }

    //// GET
    //public async Task<IActionResult> Index()
    //{
    //    List<ContractCategory> contractCategories = await _dbContext.ContractCategories.ToListAsync();

    //    return Ok(contractCategories);
    //}
}