namespace SugarDecoration.Core.Models.CartItem
{
    public class CartItemDetailsModel
    {
        public int Id { get; set; }
        public string ProductTitle { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public string CreatedOn { get; set; } = string.Empty;
    }
}
