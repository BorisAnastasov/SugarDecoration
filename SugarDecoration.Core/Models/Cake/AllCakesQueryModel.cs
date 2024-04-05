using SugarDecoration.Core.Enumerations;
using System.ComponentModel.DataAnnotations;

namespace SugarDecoration.Core.Models.Cake
{
	public class AllCakesQueryModel
    {
        public int CakesPerPage { get; } = 15;

        public string Category { get; init; } = null!;

        [Display(Name = "Search by text")]
        public string SearchTerm { get; init; } = null!;

        public ProductSorting Sorting { get; init; }

        public int CurrentPage { get; init; } = 1;

        public int TotalCakeCount { get; set; }

        public IEnumerable<string> Categories { get; set; } = null!;

        public IEnumerable<CakeServiceModel> Cakes { get; set; }
                        = new List<CakeServiceModel>();
    } 
}
