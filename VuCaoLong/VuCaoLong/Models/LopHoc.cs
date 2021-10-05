using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace VuCaoLong.Models
{
    
    [Table("LopHoc")]
    public class LopHoc
    {
        [Key]
        public int MaLop { get; set; }
        public string TenLop { get; set; }

    }
}