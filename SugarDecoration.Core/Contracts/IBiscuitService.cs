using SugarDecoration.Core.ViewModels.Cake;

namespace SugarDecoration.Core.Contracts
{
	public interface IBiscuitService
	{
		Task<IEnumerable<AllCakeViewModel>> GetAllBiscuitsAsync();
		Task<bool> ExistsByIdAsync(int id);
		Task<DetailsCakeViewModel> GetBiscuitDetailsByIdAsync(int id);
		Task AddBiscuitAsync(CakeFormViewModel model, int productId);
		Task<CakeFormViewModel> EditBiscuitAsync(int id);
		Task DeleteBiscuitAsync(int id);
	}
}
