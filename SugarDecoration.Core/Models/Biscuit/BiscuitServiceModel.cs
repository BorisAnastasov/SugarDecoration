using SugarDecoration.Core.Attributes;
using System.ComponentModel.DataAnnotations;
using static SugarDecoration.Core.Constants.MessageConstants;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Product;

namespace SugarDecoration.Core.Models.Biscuit
{
	public class BiscuitServiceModel
	{
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TitleMaxLength,
            MinimumLength = TitleMinLength,
            ErrorMessage = LengthMessage)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [MustBePositive(ErrorMessage = InvalidDecimal)]
        public string Price { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ImageUrlMaxLength,
            MinimumLength = ImageUrlMinLength,
            ErrorMessage = LengthMessage)]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
