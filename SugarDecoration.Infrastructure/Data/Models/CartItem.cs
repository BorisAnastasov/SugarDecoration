using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.CartItem;

namespace SugarDecoration.Infrastructure.Data.Models
{
    [Comment("Cart item")]
	public class CartItem
	{
        [Key]
        [Comment("CartItem identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Cart identifier")]
        public int CartId { get; set; }

        [ForeignKey(nameof(CartId))]
        public Cart Cart { get; set; } = null!;

        [Required]
        [Comment("Product identifier")]
        public int? ProductId { get; set; }
        public Product? Product { get; set; }

        [Required]
        [Comment("Quantity of the product")]
        public int Quantity { get; set; } 

        [Required]
        [MaxLength(TextMaxLength)]
        [Comment("Description of order")]
        public string Text { get; set; } = string.Empty;

        public bool IsRefToProduct
        {
            get => this.Product != null;
        }
    }
}
