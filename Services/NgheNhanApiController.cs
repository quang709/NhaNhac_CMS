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
    public class NgheNhanApiController : ApiBaseController
    {
        private readonly INgheNhanRepository _ngheNhanRepository;
        public NgheNhanApiController()
        {
            _ngheNhanRepository = new NgheNhanRepository();
        }
        [System.Web.Http.HttpGet]
        public async Task<HttpResponseMessage> Gets()
        {
            try
            {
                IEnumerable<NgheNhan> lst = null;
                lst = await _ngheNhanRepository.Gets();
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpGet]
        public async Task<HttpResponseMessage> Get(int ID)
        {
            try
            {
                NgheNhan lst = new NgheNhan();
                lst = await _ngheNhanRepository.Get(ID);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Posts(NgheNhan data)
        {
            try
            {
                NgheNhan lst = new NgheNhan();
                lst = await _ngheNhanRepository.Posts(data);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpPut]
        public async Task<HttpResponseMessage> Puts(NgheNhan data)
        {
            try
            {
                NgheNhan lst = new NgheNhan();
                lst = await _ngheNhanRepository.Puts(data);
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
                NgheNhan lst = new NgheNhan();
                lst = await _ngheNhanRepository.Delete(ID);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }

        }
        [System.Web.Http.HttpGet]
        public async Task<HttpResponseMessage> search(string tukhoa)
        {
            try
            {
                IEnumerable<NgheNhan> lst = null;
                lst = await _ngheNhanRepository.search(tukhoa);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }


    }
}