using SugarDecoration.Core.ViewModels.Contracts;
using SugarDecoration.Core.ViewModels.Home;

namespace SugarDecoration.Core.Contracts
{
	public interface IProductService
    {
        Task<int> AddProductAsync(IFormProductViewModel model);
        Task EditProductAsync(IFormProductViewModel model, int id);
        //Task<IEnumerable<ProductIndexServiceModel>> TakeFiveProducts();

	}
}
