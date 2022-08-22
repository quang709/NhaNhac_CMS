using DotNetNuke.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HueCIT.Modules.NhaNhac_CMS.Models
{
    public class NgheNghiep
    {
        [Required]
        public int MaNghe { get; set; }
        [Required]
        public string TenNghe { get; set; }
        public string MoTa { get; set; }
       
    }
    
}