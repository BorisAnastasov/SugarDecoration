using SugarDecoration.Core.ViewModels.CakeCategory;
using SugarDecoration.Core.ViewModels.Contracts;

namespace SugarDecoration.Core.ViewModels.Biscuit
{
	public class FormBiscuitViewModel:IFormProductViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Price { get; set; } = string.Empty;
		public int Quantity { get; set; }
		public int CategoryId { get; set; }
		public string ImageUrl { get; set; } = string.Empty;
		public DateTime CreatedOn { get; set; }
        public IEnumerable<CakeCategoryViewModel> CakeCategories { get; set; }
					= new List<CakeCategoryViewModel>();
    }
}
