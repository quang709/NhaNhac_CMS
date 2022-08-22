using HueCIT.Modules.NhaNhac_CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueCIT.Modules.NhaNhac_CMS.Interface
{
   public interface IKhanGiaRepository
    {
        Task<IEnumerable<KhanGia>> Gets();
        Task<KhanGia> Posts(KhanGia khanGia);
        Task<KhanGia> Puts(KhanGia khanGia);
        Task<KhanGia> Delete(int  ID);
    }
}
