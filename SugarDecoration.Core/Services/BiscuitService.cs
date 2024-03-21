using Microsoft.EntityFrameworkCore;
using SugarDecoration.Core.Contracts;
using SugarDecoration.Core.ViewModels.Cake;
using SugarDecoration.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SugarDecoration.Core.Services
{
	public class BiscuitService : IBiscuitService
	{
		private readonly SugarDecorationDb _context;
		public BiscuitService(SugarDecorationDb context)
		{
			_context = context;
		}
		public async Task<IEnumerable<AllCakeViewModel>> GetAllBiscuitsAsync()
		{
			var biscuits = await _context.Biscuits
											.AsNoTracking()
											.Select(new AllBiscuitViewModel 
											{
												
											}).ToListAsync();	
		}


		public Task AddBiscuitAsync(CakeFormViewModel model, int productId)
		{
			
		}

		public Task DeleteBiscuitAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<CakeFormViewModel> EditBiscuitAsync(int id)
		{
			throw new NotImplementedException();
		}

		public Task<bool> ExistsByIdAsync(int id)
		{
			throw new NotImplementedException();
		}

		

		public Task<DetailsCakeViewModel> GetBiscuitDetailsByIdAsync(int id)
		{
			throw new NotImplementedException();
		}
	}
}
