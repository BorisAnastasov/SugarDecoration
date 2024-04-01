using SugarDecoration.Core.Models.Contracts;

namespace SugarDecoration.Core.Contracts
{
	public interface IProductService
    {
        Task<int> AddProductAsync(IFormProductViewModel model);
        Task EditProductAsync(IFormProductViewModel model, int id);
        //Task<IEnumerable<ProductIndexServiceModel>> TakeFiveProducts();

	}
}
