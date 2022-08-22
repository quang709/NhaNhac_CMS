using HueCIT.Modules.NhaNhac_CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueCIT.Modules.NhaNhac_CMS.Interface
{
  public  interface INgheNhanRepository
    {
        Task<IEnumerable<NgheNhan>> Gets();
        Task<NgheNhan> Posts(NgheNhan ngheNhan);
        Task<NgheNhan> Puts(NgheNhan ngheNhan);
        Task<NgheNhan> Delete(int ID);
        Task<NgheNhan> Get(int ID);
        Task<IEnumerable<NgheNhan>> search(string nghenhan );

    }
}
