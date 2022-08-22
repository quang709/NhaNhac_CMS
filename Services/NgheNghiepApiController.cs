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
    public class NgheNghiepApiController : ApiBaseController
    {
        private readonly INgheNghiepRepository _ngheNghiepRepository;
        public NgheNghiepApiController()
        {
            _ngheNghiepRepository = new NgheNghiepRepository();
        }
        [System.Web.Http.HttpGet]
        public async Task<HttpResponseMessage> Gets()
        {
            try
            {
             
                IEnumerable<NgheNghiep> lst = null;
                lst = await _ngheNghiepRepository.Gets();
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
                NgheNghiep lst = new NgheNghiep();
                lst = await _ngheNghiepRepository.Get(ID);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Posts(NgheNghiep data)
        {
            try
            {
                NgheNghiep lst = new NgheNghiep();
                lst = await _ngheNghiepRepository.Posts(data);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpPut]
        public async Task<HttpResponseMessage> Puts(NgheNghiep data)
        {
            try
            {
                NgheNghiep lst = new NgheNghiep();
                lst = await _ngheNghiepRepository.Puts(data);
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
                NgheNghiep lst = new NgheNghiep();
                lst = await _ngheNghiepRepository.Delete(ID);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }

        }




    }
}