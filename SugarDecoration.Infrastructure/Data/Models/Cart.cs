using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace SugarDecoration.Infrastructure.Data.Models
{
	public class Cart
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public string CostumerId { get; set; } = null!;
        public IdentityUser Costumer { get; set; } = null!;
        public double TotalPrice { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set;}
    }
}
