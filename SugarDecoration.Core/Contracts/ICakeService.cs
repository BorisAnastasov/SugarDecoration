using SugarDecoration.Core.Enumerations;
using SugarDecoration.Core.Models.Cake;

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
        
        Task<CakeDetailsModel> GetCakeDetailsByIdAsync(int id);
        Task<bool> ExistsByIdAsync(int id);
        Task<IEnumerable<string>> AllCategoriesNames();
    }
}
