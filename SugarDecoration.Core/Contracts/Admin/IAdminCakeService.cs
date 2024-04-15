using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Core.Models.CakeCategory;

namespace SugarDecoration.Core.Contracts.Admin
{
    public interface IAdminCakeService
    {
        
        Task<bool> ExistsByIdAsync(int id);
        Task DeleteCakeConfirmedAsync(int id);
        Task<DeleteCakeViewModel?> DeleteCakeAsync(int id);
        Task<CakeFormModel> EditCakeAsync(int cakeId);
        Task EditCakeAsync(int id, CakeFormModel model);
        Task AddCakeAsync(CakeFormModel model);
        Task<IEnumerable<CakeCategoryViewModel>> GetCakeCategoriesAsync();
        Task<IEnumerable<string>> AllCategoriesNames();
        Task<bool> CakeCategoryExists(int id);
    }
}
