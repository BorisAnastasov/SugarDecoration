using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Core.Models.CakeCategory;

namespace SugarDecoration.Core.Contracts
{
    public interface ICakeService
    {
        Task<AllCakesQueryModel> GetAllCakesAsync();
        Task<bool> ExistsByIdAsync(int id);
        Task<CakeDetailsModel> GetCakeDetailsByIdAsync(int id);
        Task AddCakeAsync(CakeFormModel model);
        Task<CakeFormModel> EditCakeAsync(int cakeId);
        Task EditCakeAsync(int id,CakeFormModel model);
        Task DeleteCakeConfirmedAsync(int id);
        Task<DeleteCakeViewModel?> DeleteCakeAsync(int id);
        Task<IEnumerable<CakeCategoryViewModel>> GetCakeCategoriesAsync();
        Task<bool> CakeCategoryExists(int id);

	}
}
