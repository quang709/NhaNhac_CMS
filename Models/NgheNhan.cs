using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HueCIT.Modules.NhaNhac_CMS.Models
{
    public class NgheNhan
    {
        [Required]
        public int MaNgheNhan { get; set; }
        [Required]
        public int MaNghe { get; set; }
        public int MaAnh { get; set; }
        [Required]
        public string Ten { get; set; }
        public string HoatDongNgheThuat { get; set; }
        public int DanhHieu { get; set; }
        public string NgheDanh { get; set; }
        public int NamSinh { get; set; }
        public string QueQuan { get; set; }
        public string DiaChi { get; set; }

    
        public string TheHeNgheNhan { get; set; }
        public string NhungNoiLuuDien { get; set; }
       
        public string HocLoaiHinhNgheThuat { get; set; }
        public string SuDungNhacCu { get; set; }
        public int NamBatDauHoc { get; set; }
        public string NguoiDay { get; set; }
        public string NoiHoc { get; set; }
        public string BanCungHoc { get; set; }
        public string BanCungDien { get; set; }
        public string BiQuyetNgheNghiep { get; set; }
        public string TheHienBaiBan { get; set; }
        public string GiaiThoaiKyNiem { get; set; }
        public string TruyenThongGiaDinh { get; set; }
        public string TheHeKeTuc { get; set; }
        public string DongGopTruyenDay { get; set; }
        public string DanhHieuGiaiThuong { get; set; }
       
        public string TenNghe { get; set; }
        public string Path { get; set; }

    }
}