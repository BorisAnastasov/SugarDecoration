namespace SugarDecoration.Core.ViewModels.Cake
{
    public class DetailsCakeViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Price { get; set; } = null!;
        public int Layers { get; set; }
        public string Form { get; set; } = null!;
        public int Portions { get; set; }
        public string ImageUrl { get; set; } = null!;
    }
}
