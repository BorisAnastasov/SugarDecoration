using SugarDecoration.Core.Models.Home;

namespace SugarDecoration.Core.Contracts
{
	public interface IHomeService
	{
		Task<ProductsIndexServiceModel> GetProductsInformation();
	}
}
