using SugarDecoration.Core.ViewModels.CakeCategory;

namespace SugarDecoration.Core.ViewModels.Biscuit
{
	public class FormBiscuitViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Price { get; set; } = string.Empty;
		public int Quantity { get; set; }
		public int CategoryId { get; set; }
		public string ImageUrl { get; set; }
		public DateTime CreatedOn { get; set; }
        public IEnumerable<CakeCategoryViewModel> CakeCategories { get; set; }
					= new List<CakeCategoryViewModel>();
    }
}
