using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarDecoration.Infrastructure.Data.Models
{
    [Comment("Order item table")]
    public class OrderItem
    {
        [Key]
        [Comment("OrderItem identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("Order identifier")]
        public int OrderId { get; set; }

        [ForeignKey(nameof(OrderId))]
        public Order Order { get; set; } = null!;

        [Required]
        [Comment("Product identifier")]
        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;

        [Required]
        [Comment("Quantity of the product")]
        public int Quantity { get; set; }

        [Required]
        [Comment("Product price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
