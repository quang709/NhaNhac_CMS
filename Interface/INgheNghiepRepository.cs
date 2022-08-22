using HueCIT.Modules.NhaNhac_CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueCIT.Modules.NhaNhac_CMS.Interface
{
  public interface INgheNghiepRepository
    {
        Task<IEnumerable<NgheNghiep>> Gets();
        Task<NgheNghiep> Get(int ID);
        Task<NgheNghiep> Posts(NgheNghiep ngheNghiep);
        Task<NgheNghiep> Puts(NgheNghiep ngheNghiep);
        Task<NgheNghiep> Delete(int ID);
    }
}

