using SugarDecoration.Core.Enumerations;
using SugarDecoration.Core.Models.Biscuit;
using SugarDecoration.Core.Models.BiscuitCategory;

namespace SugarDecoration.Core.Contracts
{
	public interface IBiscuitService
	{
		Task<BiscuitQueryServiceModel> GetAllBiscuitsAsync(
										string? category = null,
										string? searchTerm = null,
										ProductSorting sorting = ProductSorting.Newest,
										int currPage = 1,
										int productsPerPage = 15);
		Task<BiscuitDetailsModel> GetBiscuitDetailsByIdAsync(int id);
		Task AddBiscuitAsync(BiscuitFormModel model);
		Task<DeleteBiscuitViewModel> DeleteBiscuitAsync(int id);
		Task DeleteBiscuitConfirmedAsync(int id);
		Task<BiscuitFormModel> EditBiscuitAsync(int id);
		Task EditBiscuitAsync(int id,BiscuitFormModel model);
        Task<bool> ExistsByIdAsync(int id);
        Task<bool> BiscuitCategoryExistsByIdAsync(int id);
		Task<IEnumerable<BiscuitCategoryViewModel>> GetBiscuitCategoriesAsync();
		Task<IEnumerable<string>> AllCategoriesNames();
	}
}
