using SugarDecoration.Core.Models.CartItem;

namespace SugarDecoration.Core.Models.Order
{
    public class OrderDetailsModel
	{
        public int Id { get; set; }
		public string OrderDate { get; set; } = string.Empty;
		public int ItemCount { get; set; }
        public IEnumerable<CartItemDetailsModel> Items { get; set; } = new List<CartItemDetailsModel>();
    }
}
