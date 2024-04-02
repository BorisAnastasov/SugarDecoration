using SugarDecoration.Core.Models.BiscuitCategory;
using SugarDecoration.Core.Models.CakeCategory;
using SugarDecoration.Core.Models.Contracts;

namespace SugarDecoration.Core.Models.Biscuit
{
	public class BiscuitFormModel:IFormProductModel
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Price { get; set; } = string.Empty;
		public int Quantity { get; set; }
		public int CategoryId { get; set; }
		public string ImageUrl { get; set; } = string.Empty;
		public string CreatedOn { get; set; } = string.Empty; 
        public IEnumerable<BiscuitCategoryViewModel> Categories { get; set; }
					= new List<BiscuitCategoryViewModel>();
    }
}
