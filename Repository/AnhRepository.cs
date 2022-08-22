using Dapper;
using HueCIT.Modules.NhaNhac_CMS.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace HueCIT.Modules.NhaNhac_CMS.Repository
{
    public class AnhRepository : ConnectDatabase,IAnhRepository
    {
        private readonly SqlConnection _conn;
        public AnhRepository()
        {
            _conn = IConnectData();
        }

     
        public async Task<Anh> Gets(string MaAnh)
        {
            using (SqlConnection conn = IConnectData())
            {
                var p = new DynamicParameters();
                try
                {
                    p.Add("MaAnh", MaAnh);
             

                    await conn.OpenAsync();
                    Anh Gets = await SqlMapper.QueryFirstOrDefaultAsync<Anh>(conn, "AnhGets", p, commandType: CommandType.StoredProcedure);

                    return Gets;

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

        public async Task<Anh> Image(string url, string filename)
        {
            using (SqlConnection conn = IConnectData())
            {
                var p = new DynamicParameters();
                try
                {
                    p.Add("Title", filename);
                    p.Add("Path", url);

                    await conn.OpenAsync();
                    Anh insert = await SqlMapper.QueryFirstOrDefaultAsync<Anh>(conn, "AnhInsert", p, commandType: CommandType.StoredProcedure);

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

        public async Task<Anh> Puts(Anh anh)
        {
            using (SqlConnection conn = IConnectData())
            {
                var p = new DynamicParameters();
                try
                {
                    p.Add("FileID", anh.FileID);
                    p.Add("Title", anh.Title);
                    p.Add("Path", anh.Path);
                    await conn.OpenAsync();
                    Anh Delete = await SqlMapper.QueryFirstOrDefaultAsync<Anh>(conn, "AnhUpdate", p, commandType: CommandType.StoredProcedure);
                    return Delete;

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
        public async Task<Anh> Delete(int ID)
        {
            using (SqlConnection conn = IConnectData())
            {
                var p = new DynamicParameters();
                try
                {
                    p.Add("FileID", ID);
                   

                    await conn.OpenAsync();
                    Anh Delete = await SqlMapper.QueryFirstOrDefaultAsync<Anh>(conn, "AnhDelete", p, commandType: CommandType.StoredProcedure);
                    return Delete;

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