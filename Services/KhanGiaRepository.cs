using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HueCIT.Modules.NhaNhac_CMS.Services
{
    public class KhanGiaRepository
    {
        Task<IEnumerable<KhanGia>> Gets();
    }
}