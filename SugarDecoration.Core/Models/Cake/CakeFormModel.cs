using SugarDecoration.Core.ViewModels.Contracts;

namespace SugarDecoration.Core.ViewModels.Cake
{
    public class CakeFormModel:IFormProductViewModel
    {
        public string Title { get; set; } = string.Empty;
        public string Price { get; set; } = string.Empty;
        public int Layers { get; set; }
        public string Form { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public int Portions { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreatedOn { get; set; }


    }
}
