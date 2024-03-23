using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.ViewModels.Biscuit;
using SugarDecoration.Infrastructure.Data.Models;

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
        public IActionResult EditBiscuit(int id)
        {
            var biscuit = new FormBiscuitViewModel();
            return View(nameof(EditBiscuit), biscuit);
        }

        [HttpPost]
        public async Task<IActionResult> EditBiscuit(FormBiscuitViewModel model,int id)
        {
            await biscuitService.EditBiscuitAsync(model, id);

            return RedirectToAction(nameof(AllBiscuits));
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
            var biscuit = new FormBiscuitViewModel();

            return View(nameof(AddBiscuit), biscuit);
        }

        [HttpPost]
        public async Task<IActionResult> AddBiscuit(FormBiscuitViewModel model)
        {
            var productId = await productService.AddProductAsync(model);

            await biscuitService.AddBiscuitAsync(model, productId);

            return View(nameof(AllBiscuits));
        }

    }
}
