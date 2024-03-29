﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SugarDecoration.Infrastructure.Constants.DataConstants.Cake;


namespace SugarDecoration.Infrastructure.Data.Models
{
	public class Cake
	{
		[Key]
        public int Id { get; set; }

		[Required]
		[Range(LayersMin,LayersMax)]
        public int Layers { get; set; }

		[Required]
		[StringLength(FormMaxLength)]
        public string Form { get; set; } = string.Empty;

        [Required]
		[Range(PortionsMax,PortionsMin)]
        public int Portions { get; set; }

		[Required]
        public int CategoryId { get; set; }

		[ForeignKey(nameof(CategoryId))]
		public CakeCategory Category { get; set; } = null!;

		[Required]
        public int ProductId { get; set; }

		[ForeignKey(nameof(ProductId))]
		public Product Product { get; set; } = null!;
    }
}
