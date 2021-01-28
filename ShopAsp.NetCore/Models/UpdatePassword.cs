using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAsp.NetCore.Models
{
    public class UpdatePassword
    {
        [Required(ErrorMessage = "Chưa nhập mật khẩu")]
        [Display(Name ="Mật khẩu cũ")]

        public string OldPassword { get; set; }

        [Display(Name = "Mật khẩu mới")]

        [Required(ErrorMessage = "Chưa nhập mật khẩu")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Ít nhất 8 ký tự bao gòm chữ và số")]
        public string NewPassword { get; set; }
        [Required(ErrorMessage = "Chưa nhập mật khẩu")]
        [Compare("NewPassword", ErrorMessage = "Mật khẩu không khớp")]
        [Display(Name = "Nhập lại mật khẩu mới")]

        public string ConfirmPassword { get; set; }
    }
}
