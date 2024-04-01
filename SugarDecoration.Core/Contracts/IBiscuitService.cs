using SugarDecoration.Core.Models.Biscuit;
using SugarDecoration.Core.ViewModels.Biscuit;

namespace SugarDecoration.Core.Contracts
{
	public interface IBiscuitService
	{
		Task<IEnumerable<AllBiscuitViewModel>> GetAllBiscuitsAsync();
		Task<bool> ExistsByIdAsync(int id);
		Task<int> EditBiscuitAsync(FormBiscuitViewModel model, int biscuitId);
		Task<DetailsBiscuitViewModel> GetBiscuitDetailsByIdAsync(int id);
		Task AddBiscuitAsync(FormBiscuitViewModel model, int productId);
		Task DeleteBiscuitAsync(int id);
	}
}
