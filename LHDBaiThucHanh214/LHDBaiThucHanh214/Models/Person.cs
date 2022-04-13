using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LHDBaiThucHanh214.Models
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        [Display(Name = "Mã")]
        public string PersonID { get; set; }
        [Display(Name = "Tên")]

        public string PersonName { get; set; }
    }
}