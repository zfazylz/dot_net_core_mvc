using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PCShop.Models
{
    public class ShoppingCartItem
    {
        public int ShoppingCartItemId { get; set; }
        public string ShoppingCartId { get; set; }
        public Hardware Hardware { get; set; }
        public int Amount { get; set; }
    }
}
