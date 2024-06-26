﻿using SugarDecoration.Core.Models.CartItem;

namespace SugarDecoration.Core.Models.Cart
{
    public class AllQueryCartModel
    {
        public int CartId { get; set; }
        public int ItemsCount { get; set; }

        public List<CartItemServiceModel> CartItems { get; set; }
                    = new List<CartItemServiceModel>();


    }
}
