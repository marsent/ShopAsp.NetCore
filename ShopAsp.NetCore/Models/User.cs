using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAsp.NetCore.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Chưa nhập email")]
        [EmailAddress(ErrorMessage = "Sai cấu trúc email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Chưa nhập mật khẩu")]
        [RegularExpression(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$", ErrorMessage = "Ít nhất 8 ký tự bao gòm chữ và số")]
        public string Password { get; set; }
        [NotMapped]
        [Required(ErrorMessage = "Chưa nhập mật khẩu")]
        [Compare("Password", ErrorMessage = "Mật khẩu không khớp")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Chưa nhập tên")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Chưa nhập họ")]
        public string LastName { get; set; }
        [DefaultValue(0)]
        public int Role { get; set; }
    }
}
