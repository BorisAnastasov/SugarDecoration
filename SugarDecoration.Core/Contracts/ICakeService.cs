using SugarDecoration.Core.Models.Cake;

namespace SugarDecoration.Core.Contracts
{
    public interface ICakeService
    {
        Task<AllCakesQueryModel> GetAllCakesAsync();
        Task<bool> ExistsByIdAsync(int id);
        Task<CakeDetailsViewModel> GetCakeDetailsByIdAsync(int id);
        Task AddCakeAsync(CakeFormModel model, int productId);
        Task<int> EditCakeAsync(CakeFormModel model, int id);
        Task DeleteCakeConfirmedAsync(int id);
        Task<DeleteCakeViewModel?> DeleteCakeAsync(int id);
        Task<int> GetProductId(int cakeId);
    }
}
