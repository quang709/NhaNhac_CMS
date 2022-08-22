using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueCIT.Modules.NhaNhac_CMS.Interface
{
   public interface IConnectDatabase
    {
        SqlConnection IConnectData();
    }
}
