using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.Models.Biscuit;

namespace SugarDecoration.App.Controllers
{
    public class BiscuitController : BaseController
    {
        private readonly IBiscuitService biscuitService;
        private readonly IProductService productService;
        public BiscuitController(IBiscuitService _biscuitService, IProductService _productService)
        {
            biscuitService = _biscuitService;
            productService = _productService;
        }

        [HttpGet]
        public async Task<IActionResult> AllBiscuits()
        {
            var biscuits = await biscuitService.GetAllBiscuitsAsync();

            return View(nameof(AllBiscuits), biscuits);
        }

        [HttpGet]
        public IActionResult EditBiscuit()
        {
            var biscuit = new BiscuitFormModel();
            return View(nameof(EditBiscuit), biscuit);
        }

        [HttpPost]
        public async Task<IActionResult> EditBiscuit(BiscuitFormModel model,int id)
        {
			int productId = await biscuitService.EditBiscuitAsync(model, id);

			return RedirectToAction(nameof(BiscuitDetails), new { id });
		}

        [HttpPost]
        public async Task<IActionResult> DeleteBiscuit(int id) 
        {
            await biscuitService.DeleteBiscuitAsync(id);

            return RedirectToAction(nameof(AllBiscuits));
        }

        [HttpGet]
        public async Task<IActionResult> BiscuitDetails(int id) 
        {
            var biscuit = await biscuitService.GetBiscuitDetailsByIdAsync(id);

            return View(nameof(BiscuitDetails), biscuit);
        }

        [HttpGet]
        public async Task<IActionResult> AddBiscuit() 
        {
            var biscuit = new BiscuitFormModel();

            return View(biscuit);
        }

        [HttpPost]
        public async Task<IActionResult> AddBiscuit(BiscuitFormModel model)
        {

            //await biscuitService.AddBiscuitAsync(model, productId);

            return View(nameof(AllBiscuits));
        }

    }
}
