using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HueCIT.Modules.NhaNhac_CMS.Models
{
    public class TacGia
    {
        [Required]
        public int MaTacGia { get; set; }
       
        public int MaAnh { get; set; }
        [Required]
        public string Ten { get; set; }
       
        public string GioiThieu { get; set; }
    }
}