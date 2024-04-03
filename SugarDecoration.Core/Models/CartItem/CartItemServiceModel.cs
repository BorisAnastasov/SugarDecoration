namespace SugarDecoration.Core.Models.CartItem
{
    public class CartItemServiceModel
    {
        public int Id { get; set; }

        public string ProductTitle { get; set; } = string.Empty;

        public string ImageUrl { get; set; } = string.Empty;

        public int Quantity { get; set; }


    }
}
