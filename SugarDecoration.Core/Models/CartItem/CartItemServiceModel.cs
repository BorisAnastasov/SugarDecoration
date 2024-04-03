namespace SugarDecoration.Core.Models.CartItem
{
    public class CartItemServiceModel
    {
        public int Id { get; set; }

        public string? ProductTitle { get; set; }

        public string? ImageUrl { get; set; }

        public int Quantity { get; set; }

        public bool IsRefToProduct
        {
            get => this.ProductTitle != null && this.ImageUrl != null;
        }

    }
}
