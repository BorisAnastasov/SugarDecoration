﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SugarDecoration.Infrastructure.Data.Constants.DataConstants.Product;


namespace SugarDecoration.Infrastructure.Data.Models
{
    [Comment("Product table")]
	public class Product
	{
        [Key]
        [Comment("Product identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLength)]
        [Comment("Product title")]
        public string Title {  get; set; } = string.Empty;

        [Required]
        [Comment("Product price")]
        [Column(TypeName ="decimal(18,2)")]
		public decimal Price { get; set; }

        [Required]
        [StringLength(ImageUrlMaxLength)]
        [Comment("Product image")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required]
        [Comment("Date of creation of the product")]
        public DateTime CreatedOn { get; set; }

        public IEnumerable<CartItem> CartItems { get; set; } 
                = new List<CartItem>();
    }
}
