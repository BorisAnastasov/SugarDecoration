using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Core.Models.Biscuit;

namespace SugarDecoration.Core.Models.Home
{
    public class ProductsIndexServiceModel
	{
        public IEnumerable<CakeIndexServiceModel> Cakes { get; set; } = new List<CakeIndexServiceModel>();
        public IEnumerable<BiscuitIndexServiceModel> Biscuits { get; set; } = new List<BiscuitIndexServiceModel>();
	}
}
