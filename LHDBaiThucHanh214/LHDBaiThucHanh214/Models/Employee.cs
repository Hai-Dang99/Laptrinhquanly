using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LHDBaiThucHanh214.Models
{
    [Table("Employees")]
    public class Employee
    {
        [key]
        public String EmployeeID { get; set; }
        public string EmployeeName { get; set; }

    }
}