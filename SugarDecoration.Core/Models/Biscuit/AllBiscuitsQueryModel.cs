using SugarDecoration.Core.Enumerations;
using SugarDecoration.Core.Models.Biscuit;
using System.ComponentModel.DataAnnotations;

namespace SugarDecoration.Core.Models.Biscuit
{
	public class AllBiscuitsQueryModel
    {
		public int BiscuitsPerPage { get; } = 15;

		public string Category { get; init; }

		[Display(Name = "Search by text")]
		public string SearchTerm { get; init; }

		public ProductSorting Sorting { get; init; }

		public int CurrentPage { get; init; } = 1;

		public int TotalBiscuitCount { get; set; }

		public IEnumerable<string> Categories { get; set; } = null!;


		public IEnumerable<BiscuitServiceModel> Biscuits { get; set; }
                        = new List<BiscuitServiceModel>();
    }
}
