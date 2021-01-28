using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAsp.NetCore.Models
{
    public class Bill
    {
        [Key]
        public int BillId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public string Status { get; set; }
        public string Pay { get; set; }
        public int Total { get; set; }
        public string Phone { get; set; }
        public string Province { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string Receiver { get; set; }
        public List<BillDetail> BillDetails { get; set; }
    }
}
