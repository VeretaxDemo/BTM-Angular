//using Btm.Api.Library.DataAccess;
//using Btm.Api.Library.Models.Contracts;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace Btm.Web.Ng.Controllers
//{
//    [ApiController]
//    [Route("api/[controller]")]
//    public class ContractCategoryController : ControllerBase
//    {
//        private readonly ReadOnlyDbContext _dbContext;

//        public ContractCategoryController(ReadOnlyDbContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        //[HttpGet]
//        ////[Route("api/contractcategory")]
//        //public async Task<IActionResult> GetAllContractCategories()
//        //{
//        //    List<ContractCategory> contractCategories = await _dbContext.ContractCategories.ToListAsync();

//        //    return Ok(contractCategories);
//        //}

//        //[HttpGet]
//        //public IEnumerable<ContractCategory> Get()
//        //{
//        //    List<ContractCategory> contractCategories = _dbContext.ContractCategories.ToList();
//        //    return contractCategories;
//        //}


//        [HttpGet]
//        public async Task<IActionResult> Get()
//        {
//            List<ContractCategory> contractCategories = await _dbContext.ContractCategories.ToListAsync();

//            return Ok(contractCategories);
//        }









//        //// GET: ContractCategoryController/Details/5
//        //public ActionResult Details(int id)
//        //{
//        //    return View();
//        //}

//        //// GET: ContractCategoryController/Create
//        //public ActionResult Create()
//        //{
//        //    return View();
//        //}

//        //// POST: ContractCategoryController/Create
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public ActionResult Create(IFormCollection collection)
//        //{
//        //    try
//        //    {
//        //        return RedirectToAction(nameof(Index));
//        //    }
//        //    catch
//        //    {
//        //        return View();
//        //    }
//        //}

//        //// GET: ContractCategoryController/Edit/5
//        //public ActionResult Edit(int id)
//        //{
//        //    return View();
//        //}

//        //// POST: ContractCategoryController/Edit/5
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public ActionResult Edit(int id, IFormCollection collection)
//        //{
//        //    try
//        //    {
//        //        return RedirectToAction(nameof(Index));
//        //    }
//        //    catch
//        //    {
//        //        return View();
//        //    }
//        //}

//        //// GET: ContractCategoryController/Delete/5
//        //public ActionResult Delete(int id)
//        //{
//        //    return View();
//        //}

//        //// POST: ContractCategoryController/Delete/5
//        //[HttpPost]
//        //[ValidateAntiForgeryToken]
//        //public ActionResult Delete(int id, IFormCollection collection)
//        //{
//        //    try
//        //    {
//        //        return RedirectToAction(nameof(Index));
//        //    }
//        //    catch
//        //    {
//        //        return View();
//        //    }
//        //}
//    }
//}
