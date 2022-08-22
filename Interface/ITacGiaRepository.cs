using HueCIT.Modules.NhaNhac_CMS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueCIT.Modules.NhaNhac_CMS.Interface
{
   public interface ITacGiaRepository
    {
        Task<IEnumerable<TacGia>> Gets();
        Task<TacGia> Posts(TacGia tacGia);
        Task<TacGia> Puts(TacGia tacGia);
        Task<TacGia> Delete(int ID);

        Task<IEnumerable<TacGia>> search(string tukhoa);

    }
}
