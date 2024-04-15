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
        Task<bool> ExistsByIdAsync(int id);
        Task<IEnumerable<string>> AllCategoriesNames();
    }
}
