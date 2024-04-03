using System.ComponentModel.DataAnnotations;
using static SugarDecoration.Core.Constants.MessageConstants;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.CartItem;


namespace SugarDecoration.Core.Models.CartItem
{
    public class CartItemFormModel
    {
        public string? ProductTitle { get; set; }
        public string? ImageUrl { get; set; }
        [Required(ErrorMessage =RequiredMessage)]
        [StringLength(TextMaxLength,
                    MinimumLength =TextMinLength,
                    ErrorMessage =LengthMessage)]
        public string Text { get; set; } = string.Empty;
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(PhoneNumberMaxLength,
                    MinimumLength = PhoneNumberMinLength,
                    ErrorMessage = LengthMessage)]
        public string PhoneNumber { get; set; } = string.Empty;
        [Required(ErrorMessage = RequiredMessage)]
        public int Quantity { get; set; }

        public int? ProductId { get; set; }

        public bool IsRefToProduct
        {
            get => this.ProductTitle != null && this.ImageUrl != null && this.ProductId != null;
        }

    }
}
