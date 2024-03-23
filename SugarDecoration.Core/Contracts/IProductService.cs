using SugarDecoration.Core.ViewModels.Biscuit;
using SugarDecoration.Core.ViewModels.Contracts;

namespace SugarDecoration.Core.Contracts
{
    public interface IProductService
    {
        Task<int> AddProductAsync(IFormProductViewModel model);
    }
}
