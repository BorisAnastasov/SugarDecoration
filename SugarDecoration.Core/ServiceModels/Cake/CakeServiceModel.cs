using System.ComponentModel.DataAnnotations;
using static SugarDecoration.Infrastructure.Constants.DataConstants.Cake;
using static SugarDecoration.Infrastructure.Constants.DataConstants.Product;
using static SugarDecoration.Core.Constants.MessageConstants;


namespace SugarDecoration.Core.ServiceModels.Cake
{
    public class CakeServiceModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(TitleMaxLength,
            MinimumLength = TitleMinLength,
            ErrorMessage = LengthMessage)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        //
        public string Price { get; set; } = string.Empty;

        [Required(ErrorMessage =RequiredMessage)]
        [MaxLength(ImageUrlMaxLength, ErrorMessage =LengthMessage)]
        public string ImageUrl { get; set; } = string.Empty;
    }
}
