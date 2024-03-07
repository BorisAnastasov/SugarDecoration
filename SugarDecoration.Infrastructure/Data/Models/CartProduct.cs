using Microsoft.AspNetCore.Identity;
using SugarDecoration.Infrastructure.Data.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace SugarDecoration.Infrastructure.Data.Models
{
	public class CartProduct
	{
        public string CostumerId { get; set; } = null!;

        public IdentityUser Costumer { get; set; } = null!;
        public int ProductId { get; set; }

        [ForeignKey(nameof(ProductId))]
        public IProduct Product { get; set; } = null!;
    }
}
