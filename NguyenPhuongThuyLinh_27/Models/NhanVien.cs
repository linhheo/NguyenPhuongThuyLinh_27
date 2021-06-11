using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenPhuongThuyLinh_27.Models
{
    [Table("NhanViens")]
    public class NhanVien
    {
        [Key]
        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        public string MaNhanVien { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string HoTen { get; set; }
        public int MaPhongBan { get; set; }
    }
}