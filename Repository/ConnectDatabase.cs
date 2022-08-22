using HueCIT.Modules.NhaNhac_CMS.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace HueCIT.Modules.NhaNhac_CMS.Repository
{
    public class ConnectDatabase : IConnectDatabase
    {
        public SqlConnection IConnectData()
        {
            try
            {
                var conn = new SqlConnection
                {
                    ConnectionString = @"Data Source=DESKTOP-VT3OH29;Initial Catalog=testdotnetnuke;User ID=quang; Password=az123456"
                };

                return conn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}