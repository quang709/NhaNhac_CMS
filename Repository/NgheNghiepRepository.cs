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
    public class NgheNghiepRepository : ConnectDatabase, INgheNghiepRepository
    {

        private readonly SqlConnection _conn;
        public NgheNghiepRepository()
        {
            _conn = IConnectData();
        }

        public async Task<NgheNghiep> Get(int ID)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {
                    p.Add("MaNghe", ID);


                    NgheNghiep ngheNghiep = await SqlMapper.QueryFirstOrDefaultAsync<NgheNghiep>(conn, "NgheNghiepGet", p, commandType: CommandType.StoredProcedure);
                    return ngheNghiep;

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

        public async Task<IEnumerable<NgheNghiep>> Gets()
        {
            using (SqlConnection conn = IConnectData())
            {

                try
                {

                    await conn.OpenAsync();
                    IEnumerable<NgheNghiep> list = conn.Query<NgheNghiep>("NgheNghiepGets", commandType: CommandType.StoredProcedure);
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

        public async Task<NgheNghiep> Posts(NgheNghiep ngheNghiep)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {
                   
                    p.Add("TenNghe", ngheNghiep.TenNghe);
                    p.Add("MoTa", ngheNghiep.MoTa);

                    NgheNghiep insert = await SqlMapper.QueryFirstOrDefaultAsync<NgheNghiep>(conn, "NgheNghiepInsert", p, commandType: CommandType.StoredProcedure);

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

        public async Task<NgheNghiep> Puts(NgheNghiep ngheNghiep)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {

                    p.Add("TenNghe", ngheNghiep.TenNghe);
                    p.Add("MoTa", ngheNghiep.MoTa);
                    p.Add("MaNghe", ngheNghiep.MaNghe);
                    NgheNghiep update = await SqlMapper.QueryFirstOrDefaultAsync<NgheNghiep>(conn, "NgheNghiepUpdate", p, commandType: CommandType.StoredProcedure);

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


        public async Task<NgheNghiep> Delete(int id)
        {
            using (SqlConnection conn = IConnectData())
            {
                await conn.OpenAsync();
                var p = new DynamicParameters();
                try
                {

                  
                    p.Add("MaNghe", id);
                    NgheNghiep delete = await SqlMapper.QueryFirstOrDefaultAsync<NgheNghiep>(conn, "NgheNghiepDelete", p, commandType: CommandType.StoredProcedure);

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