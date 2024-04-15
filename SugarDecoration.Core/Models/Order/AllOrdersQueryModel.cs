namespace SugarDecoration.Core.Models.Order
{
	public class AllOrdersQueryModel
	{
        public int TotalOrderCount { get; set; }

        public IEnumerable<OrderServiceModel> Orders { get; set; } 
                = new List<OrderServiceModel>();
    }
}
