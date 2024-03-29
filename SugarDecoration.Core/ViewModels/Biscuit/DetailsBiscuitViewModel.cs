﻿namespace SugarDecoration.Core.ViewModels.Biscuit
{
	public class DetailsBiscuitViewModel
	{
		public int Id { get; set; }
		public string Title { get; set; } = string.Empty;
		public string Price { get; set; } = string.Empty;
		public int Quantity { get; set; }
		public string Category { get; set; } = null!;
		public string ImageUrl { get; set; } = string.Empty;
	}
}
