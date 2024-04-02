using SugarDecoration.Core.Models.Cake;
using SugarDecoration.Core.ViewModels.Biscuit;

namespace SugarDecoration.Core.Models.Biscuit
{
    public class AllBiscuitsQueryModel
    {
        public int TotalBiscuitCount { get; set; }

        public int BiscuitsPerPage { get; } = 10;

        public int CurrentPage { get; init; } = 1;

        public IEnumerable<BiscuitServiceModel> Biscuits { get; set; }
                        = new List<BiscuitServiceModel>();
    }
}
