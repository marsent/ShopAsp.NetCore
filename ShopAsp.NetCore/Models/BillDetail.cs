using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAsp.NetCore.Models
{
    public class BillDetail
    {
        [Key]
        public int BillDetailId { get; set; }
        public int BillId { get; set; }
        public Bill Bills { get; set; }
        public int ProductId { get; set; }
        public Product Products { get; set; }
        public int quantity { get; set; }
        public int TotalPrice { get; set; }

    }
}

