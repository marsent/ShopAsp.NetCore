using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAsp.NetCore.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }
        public User Users { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public int Quantity { get; set; }
    }
}
