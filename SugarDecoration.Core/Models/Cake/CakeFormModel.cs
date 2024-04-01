using SugarDecoration.Core.Models.CakeCategory;
using SugarDecoration.Core.Models.Contracts;

namespace SugarDecoration.Core.Models.Cake
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
        public IEnumerable<CakeCategoryViewModel> Categories { get; set; } 
                    = new List<CakeCategoryViewModel>();
        public DateTime CreatedOn { get; set; }


    }
}
