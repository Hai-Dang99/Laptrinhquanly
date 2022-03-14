using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LHDBaiThucHanh214.Models
{
    [Table("HaiDangs")]
    public class HaiDang
    {
        [Key]
        public string HaiDangID { get; set; }
        public string HaiDangName { get; set; }
    }
}