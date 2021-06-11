using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenPhuongThuyLinh_27.Models
{
    [Table("CheckAccounts")]
    public class CheckAccount
    {
        [Key]
        [Required(ErrorMessage = "Tên đăng nhập không được để trống.")]
        public string CheckUsername { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống.")]
        [DataType(DataType.Password)]
        public string CheckPassword { get; set; }
    }
}