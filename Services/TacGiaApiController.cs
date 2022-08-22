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
using System.Web.Mvc;

namespace HueCIT.Modules.NhaNhac_CMS.Services
{
    public class TacGiaApiController : ApiBaseController
    {
        private readonly ITacGiaRepository _tacGiaRepository;
        public TacGiaApiController()
        {
            _tacGiaRepository = new TacGiaRepository();
        }
        [System.Web.Http.HttpGet]
        public async Task<HttpResponseMessage> Gets()
        {
            try
            {
                IEnumerable<TacGia> lst = null;
                lst = await _tacGiaRepository.Gets();
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> Posts(TacGia data)
        {
            try
            {
                TacGia lst = new TacGia();
                lst = await _tacGiaRepository.Posts(data);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }


        [System.Web.Http.HttpPut]
        public async Task<HttpResponseMessage> Puts(TacGia data)
        {
            try
            {
                TacGia lst = new TacGia();
                lst = await _tacGiaRepository.Puts(data);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }

        }

        [System.Web.Http.HttpDelete]
        [System.Web.Http.Route("Delete/{ID}")]
        public async Task<HttpResponseMessage> Delete(int ID)
        {
            try
            {
                TacGia lst = new TacGia();
                lst = await _tacGiaRepository.Delete(ID);
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
                IEnumerable<TacGia> lst = null;
                lst = await _tacGiaRepository.search(tukhoa);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

    }
}