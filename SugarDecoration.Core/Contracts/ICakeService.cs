using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Core.ViewModels.Cake;

namespace SugarDecoration.Core.Contracts
{
    public interface ICakeService
    {
        Task<IEnumerable<AllCakeViewModel>> GetAllCakesAsync();
        Task<bool> ExistsByIdAsync(int id);
        Task<DetailsCakeViewModel> GetCakeDetailsByIdAsync(int id);
        Task AddCakeAsync(CakeFormViewModel model, int productId);
        Task<CakeFormViewModel> EditCakeAsync(int id);
        Task DeleteCakeAsync(int id);
    }
}
