using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NguyenPhuongThuyLinh_27.Models
{
    [Table("PhongBans")]
    public class PhongBan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaPhongBan { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string TenPhongBan { get; set; }
    }
}