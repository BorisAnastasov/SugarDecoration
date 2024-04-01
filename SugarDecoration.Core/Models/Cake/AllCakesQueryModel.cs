namespace SugarDecoration.Core.Models.Cake
{
	public class AllCakesQueryModel
    {
        public int TotalCakeCount { get; set; }

        public int CakesPerPage { get; } = 10;

        public int CurrentPage { get; init; } = 1;

        public IEnumerable<CakeServiceModel> Cakes { get; set; }
                        = new List<CakeServiceModel>();
    } 
}
