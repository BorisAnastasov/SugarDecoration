namespace SugarDecoration.Core.Models.Cake
{
    public class CakeDetailsModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
		public int Layers { get; set; }
        public string Form { get; set; } = string.Empty;
		public int Portions { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
	}
}
