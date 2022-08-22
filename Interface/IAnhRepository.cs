using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HueCIT.Modules.NhaNhac_CMS.Interface
{
    public  interface IAnhRepository
    {
        Task<Anh> Image (string url, string filename);
        Task<Anh> Gets(string MaAnh);
        Task<Anh> Puts(Anh anh);
        Task<Anh> Delete(int ID);
    }
}
