namespace SugarDecoration.Core.Models.CartItem
{
    public class CartItemDetailsModel
    {
        public int Id { get; set; }
        public string? ProductTitle { get; set; }
        public string? ImageUrl { get; set; }
        public string Text { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int Quantity { get; set; }
        public bool IsRefToProduct()
           => this.ProductTitle != null && this.ImageUrl != null;
        
    }
}
