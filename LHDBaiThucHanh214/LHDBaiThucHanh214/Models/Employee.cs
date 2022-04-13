using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LHDBaiThucHanh214.Models
{
    [Table("Employees")]
    public class Employee
    {
        [key]
        [Display(Name = "Mã Nhân Viên")]
        public string EmployeeID { get; set; }
        [Display(Name = "Tên Nhân Viên")]
        public string EmployeeName { get; set; }
    }
}