using SugarDecoration.Core.ViewModels.Biscuit;

namespace SugarDecoration.Core.Contracts
{
	public interface IBiscuitService
	{
		Task<IEnumerable<AllBiscuitViewModel>> GetAllBiscuitsAsync();
		Task<bool> ExistsByIdAsync(int id);
		Task<DetailsBiscuitViewModel> GetBiscuitDetailsByIdAsync(int id);
		Task AddBiscuitAsync(FormBiscuitViewModel model, int productId);
		Task<FormBiscuitViewModel> EditBiscuitAsync(int id);
		Task DeleteBiscuitAsync(int id);
	}
}
