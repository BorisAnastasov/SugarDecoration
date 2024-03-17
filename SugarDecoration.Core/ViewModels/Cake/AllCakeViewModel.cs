namespace SugarDecoration.Core.ViewModels.Cake
{
    public class AllCakeViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public int Layers { get; set; }
        public int Portion { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
    } 
}
