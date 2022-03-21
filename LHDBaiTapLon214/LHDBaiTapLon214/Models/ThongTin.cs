using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LHDBaiTapLon214.Models
{
    [Table("ThongTin")]
    public class ThongTin
    {
        [Key]
        [Display(Name = "Mã Sinh Viên")]
        [Required(ErrorMessage = "Mã sinh viên không được bỏ trống")]
        public string MaSinhVien { get; set; }
        [Display(Name = "Tên Sinh Viên")]
        [Required(ErrorMessage = "Tên sinh viên không được bỏ trống")]
        public string TenSinhVien { get; set; }
        [Display(Name = "Ngày Sinh")]
        [Required(ErrorMessage = "Ngày Sinh không được bỏ trống")]
        public string NgayThangNam { get; set; }
    }
}