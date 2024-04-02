using SugarDecoration.Core.Attributes;
using SugarDecoration.Core.Models.CakeCategory;
using SugarDecoration.Core.Models.Contracts;
using System.ComponentModel.DataAnnotations;
using static SugarDecoration.Core.Constants.MessageConstants;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Product;

namespace SugarDecoration.Core.Models.Cake
{
    public class CakeFormModel:IFormProductModel
    {

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TitleMaxLength,
                MinimumLength = TitleMinLength,
                ErrorMessage = LengthMessage)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [MustBePositive(ErrorMessage = InvalidDecimal)]
        public string Price { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        public int Layers { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        public string Form { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ImageUrlMaxLength,
            MinimumLength = ImageUrlMinLength,
            ErrorMessage = LengthMessage)]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        public int Portions { get; set; }
        [Required(ErrorMessage = RequiredMessage)]
        public int CategoryId { get; set; }
        public IEnumerable<CakeCategoryViewModel> Categories { get; set; } 
                    = new List<CakeCategoryViewModel>();

        [Required(ErrorMessage = RequiredMessage)]
        public string CreatedOn { get; set; } = string.Empty;


    }
}
