namespace SugarDecoration.Core.Models.Cake
{
    public class CakeQueryServiceModel
    {
        public int TotalCakeCount { get; set; }
        public IEnumerable<CakeServiceModel> Cakes { get; set; }
                            = new List<CakeServiceModel>();
    }
}
