using Microsoft.AspNetCore.Mvc;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Infrastructure.Data.Contracts;

namespace SugarDecoration.App.Controllers
{
	public class BiscuitController : BaseController
	{
		private readonly IBiscuitService biscuitService;
        public BiscuitController(IBiscuitService _biscuitService)
        {
            biscuitService = _biscuitService;
        }

		public 




        public IActionResult Index()
		{
			return View();
		}
	}
}
