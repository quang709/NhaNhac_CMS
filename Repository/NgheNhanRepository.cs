using Dapper;
using HueCIT.Modules.NhaNhac_CMS.Interface;
using HueCIT.Modules.NhaNhac_CMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HueCIT.Modules.NhaNhac_CMS.Repository
{
    public class NgheNhanRepository : ConnectDatabase, INgheNhanRepository
    {
        public async Task<IEnumerable<NgheNhan>> Gets()
        {
            using (SqlConnection conn = IConnectData())
            {

                try
                {

                    await conn.OpenAsync();
                    IEnumerable<NgheNhan> list = conn.Query<NgheNhan>("NgheNhanGets", commandType: CommandType.StoredProcedure);
                    return list;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }
        public async Task<NgheNhan> Get(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {
                    p.Add("MaNgheNhan", id);


                    NgheNhan nghenhan = await SqlMapper.QueryFirstOrDefaultAsync<NgheNhan>(conn, "NgheNhanGet", p, commandType: CommandType.StoredProcedure);
                    return nghenhan;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }





        }
        public async Task<NgheNhan> Posts(NgheNhan ngheNhan)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {
                    string maAnh = null;
                    if (ngheNhan.MaAnh != 0)
                    {
                        maAnh = ngheNhan.MaAnh.ToString();
                    }
                    p.Add("Ten", ngheNhan.Ten);
                    p.Add("MaAnh", maAnh);
                    p.Add("MaNghe", ngheNhan.MaNghe);
                    p.Add("HoatDongNgheThuat", ngheNhan.HoatDongNgheThuat);
                    p.Add("NgheDanh", ngheNhan.NgheDanh);
                    p.Add("DanhHieu", ngheNhan.DanhHieu);
                    p.Add("NamSinh", ngheNhan.NamSinh);
                    p.Add("QueQuan", ngheNhan.QueQuan);
                    p.Add("DiaChi", ngheNhan.DiaChi);
                    p.Add("NhungNoiLuuDien", ngheNhan.NhungNoiLuuDien);                    
                    p.Add("TheHeNgheNhan", ngheNhan.TheHeNgheNhan);
                    p.Add("HocLoaiHinhNgheThuat", ngheNhan.HocLoaiHinhNgheThuat);
                    p.Add("SuDungNhacCu", ngheNhan.SuDungNhacCu);
                    p.Add("NamBatDauHoc", ngheNhan.NamBatDauHoc);
                    p.Add("NguoiDay", ngheNhan.NguoiDay);
                    p.Add("NoiHoc", ngheNhan.NoiHoc);
                    p.Add("BanCungHoc", ngheNhan.BanCungHoc);
                    p.Add("BanCungDien", ngheNhan.BanCungDien);
                    p.Add("BiQuyetNgheNghiep", ngheNhan.BiQuyetNgheNghiep);
                    p.Add("TheHienBaiBan", ngheNhan.TheHienBaiBan);                  
                    p.Add("GiaiThoaiKyNiem", ngheNhan.GiaiThoaiKyNiem);
                    p.Add("TruyenThongGiaDinh", ngheNhan.TruyenThongGiaDinh);
                    p.Add("TheHeKeTuc", ngheNhan.TheHeKeTuc);
                    p.Add("DongGopTruyenDay", ngheNhan.DongGopTruyenDay);
                    p.Add("DanhHieuGiaiThuong", ngheNhan.DanhHieuGiaiThuong);

                   
                    NgheNhan insert = await SqlMapper.QueryFirstOrDefaultAsync<NgheNhan>(conn, "NgheNhanInsert", p, commandType: CommandType.StoredProcedure);

                    return insert;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

        public async Task<NgheNhan> Puts(NgheNhan ngheNhan)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {
                
                    string maAnh = null;
                    if (ngheNhan.MaAnh != 0)
                    {
                        maAnh = ngheNhan.MaAnh.ToString();
                    }
                    p.Add("MaNgheNhan", ngheNhan.MaNgheNhan);
                    p.Add("Ten", ngheNhan.Ten);
                  
                    p.Add("MaAnh", maAnh);
                    p.Add("MaNghe", ngheNhan.MaNghe);

                    p.Add("HoatDongNgheThuat", ngheNhan.HoatDongNgheThuat);
                    p.Add("NgheDanh", ngheNhan.NgheDanh);
                    p.Add("DanhHieu", ngheNhan.DanhHieu);
                    p.Add("NamSinh", ngheNhan.NamSinh);
                    p.Add("QueQuan", ngheNhan.QueQuan);
                    p.Add("DiaChi", ngheNhan.DiaChi);
                    p.Add("NhungNoiLuuDien", ngheNhan.NhungNoiLuuDien);
                    p.Add("TheHeNgheNhan", ngheNhan.TheHeNgheNhan);
                    p.Add("HocLoaiHinhNgheThuat", ngheNhan.HocLoaiHinhNgheThuat);
                    p.Add("SuDungNhacCu", ngheNhan.SuDungNhacCu);
                    p.Add("NamBatDauHoc", ngheNhan.NamBatDauHoc);
                    p.Add("NguoiDay", ngheNhan.NguoiDay);
                    p.Add("NoiHoc", ngheNhan.NoiHoc);
                    p.Add("BanCungHoc", ngheNhan.BanCungHoc);
                    p.Add("BanCungDien", ngheNhan.BanCungDien);
                    p.Add("BiQuyetNgheNghiep", ngheNhan.BiQuyetNgheNghiep);
                    p.Add("TheHienBaiBan", ngheNhan.TheHienBaiBan);
                    p.Add("GiaiThoaiKyNiem", ngheNhan.GiaiThoaiKyNiem);
                    p.Add("TruyenThongGiaDinh", ngheNhan.TruyenThongGiaDinh);
                    p.Add("TheHeKeTuc", ngheNhan.TheHeKeTuc);
                    p.Add("DongGopTruyenDay", ngheNhan.DongGopTruyenDay);
                    p.Add("DanhHieuGiaiThuong", ngheNhan.DanhHieuGiaiThuong);

                    NgheNhan update = await SqlMapper.QueryFirstOrDefaultAsync<NgheNhan>(conn, "NgheNhanUpdate", p, commandType: CommandType.StoredProcedure);
                    return update;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }


        public async Task<NgheNhan> Delete(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {
                    p.Add("MaNgheNhan", id);


                    NgheNhan delete = await SqlMapper.QueryFirstOrDefaultAsync<NgheNhan>(conn, "NgheNhanDelete", p, commandType: CommandType.StoredProcedure);
                    return delete;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }





        }



        public async Task<IEnumerable<NgheNhan>> search(string tukhoa)
        {
            using (SqlConnection conn = IConnectData())
            {
                var p = new DynamicParameters();
                try
                {
                    p.Add("Ten", tukhoa);
                 

                    await conn.OpenAsync();
                    IEnumerable<NgheNhan> list = conn.Query<NgheNhan>("NgheNhanSearch", p, commandType: CommandType.StoredProcedure);
                    return list;

                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    if (conn != null)
                    {
                        conn.Close();
                    }
                }
            }
        }

    }
}