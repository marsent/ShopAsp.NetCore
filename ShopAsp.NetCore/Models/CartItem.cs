using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAsp.NetCore.Models
{
    public class CartItem
    {
        public Product Product { get; set; }
        public Cart Cart { get; set; }
    }
}
