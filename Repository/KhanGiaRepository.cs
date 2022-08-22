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
    public class KhanGiaRepository : ConnectDatabase, IKhanGiaRepository

    {
        private readonly SqlConnection _conn;
        public KhanGiaRepository()
        {
            _conn = IConnectData();
        }

        public async Task<IEnumerable<KhanGia>> Gets()
        {
            using (SqlConnection conn = IConnectData())
            {

                try
                {

                    await conn.OpenAsync();
                    IEnumerable<KhanGia> list = conn.Query<KhanGia>("KhanGiaGets", commandType: CommandType.StoredProcedure);
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

        public async Task<KhanGia> Posts(KhanGia khanGia)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {

                    p.Add("LoaiKhanGia", khanGia.LoaiKhanGia);
                    p.Add("MoTa", khanGia.MoTa);

                    KhanGia insert = await SqlMapper.QueryFirstOrDefaultAsync<KhanGia>(conn, "KhanGiaInsert", p, commandType: CommandType.StoredProcedure);

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

        public async Task<KhanGia> Puts(KhanGia khanGia)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {

                    p.Add("LoaiKhanGia", khanGia.LoaiKhanGia);
                    p.Add("MoTa", khanGia.MoTa);
                    p.Add("MaKhanGia", khanGia.MaKhanGia);
                    KhanGia update = await SqlMapper.QueryFirstOrDefaultAsync<KhanGia>(conn, "KhanGiaUpdate", p, commandType: CommandType.StoredProcedure);

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

        public async Task<KhanGia> Delete(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {


                    p.Add("MaKhanGia", id);
                    KhanGia delete = await SqlMapper.QueryFirstOrDefaultAsync<KhanGia>(conn, "KhanGiaDelete", p, commandType: CommandType.StoredProcedure);

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

    }
}