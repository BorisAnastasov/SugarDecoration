using SugarDecoration.Core.Models.CartItem;

namespace SugarDecoration.Core.Models.Cart
{
    public class AllQueryCartModel
    {
        public int ItemsCount { get; set; }

        public IEnumerable<CartItemServiceModel> CartItems { get; set; }
                    = new List<CartItemServiceModel>();


    }
}
