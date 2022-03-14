using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LHDBaiThucHanh214.Models
{
    [Table("Student5s")]
    public class Student5
    {
        [Key]
        public string Student5ID { get; set; }
        public string Student5Name { get; set; }
    }
}