using SugarDecoration.Infrastructure.Data.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace SugarDecoration.Infrastructure.Data.Categories
{
	public class CakeCategory : ICategory
	{
		[Key]
        public int Id { get; set; }
		[Required]
        public string Name { get; set; } = string.Empty;
	}
}
