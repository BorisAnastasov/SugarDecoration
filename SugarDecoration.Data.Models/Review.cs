using Microsoft.AspNetCore.Identity;
using SugarDecoration.Data.Models.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarDecoration.Data.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CostumerId { get; set; } = null!;

        [ForeignKey(nameof(CostumerId))]
        public IdentityUser Costumer { get; set; } = null!;

        [Required]
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public IProduct Product { get; set; } = null!;

        [Required]
        public string Commment { get; set; } = null!;

        [Required]
        public double Rating { get; set; }
    }
}
