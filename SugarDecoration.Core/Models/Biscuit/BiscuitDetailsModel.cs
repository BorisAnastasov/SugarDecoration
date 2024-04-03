namespace SugarDecoration.Core.Models.Biscuit
{
	public class BiscuitDetailsModel
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Price { get; set; } = string.Empty;
		public int Quantity { get; set; }
		public string ImageUrl { get; set; } = string.Empty;
	}
}
