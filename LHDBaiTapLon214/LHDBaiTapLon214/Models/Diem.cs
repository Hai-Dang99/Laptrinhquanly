using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LHDBaiTapLon214.Models
{
    [Table("Diem")]
    public class Diem
    {
        [Key]
        [Display(Name = "Điểm A")]
        [Required(ErrorMessage = "Điểm không được bỏ trống")]
        public string DiemA { get; set; }
        [Display(Name = "Điểm B")]
        [Required(ErrorMessage = "Điểm không được bỏ trống")]
        public string DiemB { get; set; }
        [Display(Name = "Điểm C")]
        [Required(ErrorMessage = "Điểm không được bỏ trống")]
        public string DiemC { get; set; }
        [Display(Name = "Mã Học Phần")]
        [Required(ErrorMessage = "Mã Học Phần không được bỏ trống")]
        public string MaHocPhan { get; set; }
        [Display(Name = "Mã Sinh Viên")]
        [Required(ErrorMessage = "Mã Sinh Viên không được bỏ trống")]
        public string MaSinhVien { get; set; }
    }
}