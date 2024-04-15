using SugarDecoration.Core.Models.Biscuit;
using SugarDecoration.Core.Models.BiscuitCategory;

namespace SugarDecoration.Core.Contracts.Admin
{
    public interface IAdminBiscuitService
    {
        Task<bool> ExistsByIdAsync(int id);
        Task AddBiscuitAsync(BiscuitFormModel model);
        Task<DeleteBiscuitViewModel> DeleteBiscuitAsync(int id);
        Task DeleteBiscuitConfirmedAsync(int id);
        Task<BiscuitFormModel> EditBiscuitAsync(int id);
        Task EditBiscuitAsync(int id, BiscuitFormModel model);
        Task<bool> BiscuitCategoryExistsByIdAsync(int id);
        Task<IEnumerable<BiscuitCategoryViewModel>> GetBiscuitCategoriesAsync();
        Task<IEnumerable<string>> AllCategoriesNames();
    }
}
