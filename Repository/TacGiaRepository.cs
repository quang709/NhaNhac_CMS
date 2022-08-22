using HueCIT.Modules.NhaNhac_CMS.Interface;
using HueCIT.Modules.NhaNhac_CMS.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Dapper;

using Christoc.Modules.nhanhac.Models;

namespace HueCIT.Modules.NhaNhac_CMS.Repository
{

    public class TacGiaRepository : ConnectDatabase, ITacGiaRepository
    {
        private readonly SqlConnection _conn;
        public TacGiaRepository()
        {
            _conn = IConnectData();
        }



        public async Task<IEnumerable<TacGia>> Gets()
        {
            using (SqlConnection conn = IConnectData())
            {

                try
                {

                    await conn.OpenAsync();
                    IEnumerable<TacGia> list = conn.Query<TacGia>("TacGiaGets", commandType: CommandType.StoredProcedure);
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

        public async Task<TacGia> Posts(TacGia tacGia)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {
                    string maAnh = null;
                    if (tacGia.MaAnh != 0)
                    {
                        maAnh = tacGia.MaAnh.ToString();
                    }
                    p.Add("Ten", tacGia.Ten);
                    p.Add("GioiThieu", tacGia.GioiThieu);
                    p.Add("MaAnh", maAnh);

                    TacGia insert = await SqlMapper.QueryFirstOrDefaultAsync<TacGia>(conn, "TacGiaInsert", p, commandType: CommandType.StoredProcedure);

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

        public async Task<TacGia> Puts(TacGia tacGia)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {
                    string maAnh = null;
                    if (tacGia.MaAnh != 0)
                    {
                        maAnh = tacGia.MaAnh.ToString();
                    }
                    p.Add("MaTacGia", tacGia.MaTacGia);
                    p.Add("Ten", tacGia.Ten);
                    p.Add("MaAnh", maAnh);
                    p.Add("GioiThieu", tacGia.GioiThieu);



                    TacGia update = await SqlMapper.QueryFirstOrDefaultAsync<TacGia>(conn, "TacGiaUpdate", p, commandType: CommandType.StoredProcedure);
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


        public async Task<TacGia> Delete(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {
                    p.Add("MaTacGia", id);


                    TacGia delete = await SqlMapper.QueryFirstOrDefaultAsync<TacGia>(conn, "TacGiaDelete", p, commandType: CommandType.StoredProcedure);
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

        public async Task<IEnumerable<TacGia>> search(string tukhoa)
        {
            using (SqlConnection conn = IConnectData())
            {
                var p = new DynamicParameters();
                try
                {
                    p.Add("Ten", tukhoa);


                    await conn.OpenAsync();
                    IEnumerable<TacGia> list = conn.Query<TacGia>("TacGiaSearch", p, commandType: CommandType.StoredProcedure);
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
