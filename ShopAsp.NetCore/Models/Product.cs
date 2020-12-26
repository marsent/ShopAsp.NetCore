using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAsp.NetCore.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Chưa nhập tên")]
        [Display(Name = "Tên sản phẩm")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Chưa nhập nhãn hiệu")]
        [Display(Name = "Nhãn hiệu")]
        public string Brand { get; set; }
        public string ImageUrl { get; set; }
        [NotMapped]
        [Display(Name = "Ảnh")]

        public IFormFile ImageFile { get; set; }
        [Required(ErrorMessage = "Chưa nhập giá")]
        [Display(Name = "Giá")]

        public int Price { get; set; }
        [Display(Name = "Mô tả")]
        public string Description { get; set; }
        [Column(TypeName = "smalldatetime")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateCreate { get; set; }
        [Column(TypeName = "smalldatetime")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime DateUpdate { get; set; }
        [Display(Name = "Sản phẩm nổi bậc")]
        public bool OutstandingProducts { get; set; }
        [Display(Name = "Khuyến mãi hot")]
        public bool HotProduct { get; set; }
        public List<Cart> Carts { get; set; }
        public List<BillDetail> BillDetails { get; set; }
    }
}
