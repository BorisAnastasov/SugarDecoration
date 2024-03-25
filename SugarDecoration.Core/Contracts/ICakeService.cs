using SugarDecoration.Core.ViewModels.Cake;

namespace SugarDecoration.Core.Contracts
{
    public interface ICakeService
    {
        Task<IEnumerable<AllCakeViewModel>> GetAllCakesAsync();
        Task<bool> ExistsByIdAsync(int id);
        Task<DetailsCakeViewModel> GetCakeDetailsByIdAsync(int id);
        Task AddCakeAsync(FormCakeViewModel model, int productId);
        Task<int> EditCakeAsync(FormCakeViewModel model, int id);
        Task DeleteCakeConfirmedAsync(int id);
        Task<DeleteCakeViewModel> DeleteCakeAsync(int id);
        Task<int> GetProductId(int cakeId);
    }
}
