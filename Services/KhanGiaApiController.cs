using HueCIT.Modules.NhaNhac_CMS.Interface;
using HueCIT.Modules.NhaNhac_CMS.Models;
using HueCIT.Modules.NhaNhac_CMS.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace HueCIT.Modules.NhaNhac_CMS.Services
{
    public class KhanGiaApiController: ApiBaseController
    {
        private readonly IKhanGiaRepository _khanGiaRepository;
        public KhanGiaApiController()
        {
            _khanGiaRepository = new KhanGiaRepository();
        }
        [System.Web.Http.HttpGet]
        public async Task<HttpResponseMessage> Gets()
        {
            try
            {
                IEnumerable<KhanGia> lst = null;
                lst = await _khanGiaRepository.Gets();
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Posts(KhanGia data)
        {
            try
            {
                KhanGia lst = new KhanGia();
                lst = await _khanGiaRepository.Posts(data);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPut]
        public async Task<HttpResponseMessage> Puts(KhanGia data)
        {
            try
            {
                KhanGia lst = new KhanGia();
                lst = await _khanGiaRepository.Puts(data);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }

        }

        [System.Web.Http.Route("Delete/{ID}")]
        public async Task<HttpResponseMessage> Delete(int ID)
        {
            try
            {
                KhanGia lst = new KhanGia();
                lst = await _khanGiaRepository.Delete(ID);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }

        }

    }
}