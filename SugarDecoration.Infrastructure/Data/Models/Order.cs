using Microsoft.EntityFrameworkCore;
using SugarDecoration.Infrastructure.Data.Models.Account;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarDecoration.Infrastructure.Data.Models
{
    [Comment("Order table")]
    public class Order
    {
        [Key]
        [Comment("Order identifier")]
        public int Id { get; set; }

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = null!;

        public ApplicationUser User { get; set; } = null!;

        [Required]
        [Comment("Sum of the prices of the products")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalPrice { get; set; }

        [Required]
        [Comment("Date of order")]
        public DateTime OrderDate { get; set; }


    }
}
