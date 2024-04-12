using SugarDecoration.Core.Models.Cake;

namespace SugarDecoration.Core.Models.Biscuit
{
	public class BiscuitQueryServiceModel
	{
		public int TotalBiscuitCount { get; set; }
		public IEnumerable<BiscuitServiceModel> Biscuits { get; set; }
							= new List<BiscuitServiceModel>();
	}
}
