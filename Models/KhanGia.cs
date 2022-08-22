using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HueCIT.Modules.NhaNhac_CMS.Models.KhanGia))]

namespace HueCIT.Modules.NhaNhac_CMS.Models
{
    public class KhanGia
    {
        [Required]
        public int MaKhanGia { get; set; }
        [Required]
        public string LoaiKhanGia { get; set; }
        public string MoTa { get; set; }
    }
}
