using SugarDecoration.Core.Enumerations;
using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Core.Models.CakeCategory;

namespace SugarDecoration.Core.Contracts
{
    public interface ICakeService
    {
        Task<CakeQueryServiceModel> GetAllCakesAsync(
                                        string? category = null,
                                        string? searchTerm = null,
                                        ProductSorting sorting = ProductSorting.Newest,
                                        int currPage = 1,
                                        int productsPerPage = 15);
        Task<bool> ExistsByIdAsync(int id);
        Task<CakeDetailsModel> GetCakeDetailsByIdAsync(int id);
        Task AddCakeAsync(CakeFormModel model);
        Task<CakeFormModel> EditCakeAsync(int cakeId);
        Task EditCakeAsync(int id,CakeFormModel model);
        Task DeleteCakeConfirmedAsync(int id);
        Task<DeleteCakeViewModel?> DeleteCakeAsync(int id);
        Task<IEnumerable<CakeCategoryViewModel>> GetCakeCategoriesAsync();
        Task<IEnumerable<string>> AllCategoriesNames();
        Task<bool> CakeCategoryExists(int id);

	}
}
