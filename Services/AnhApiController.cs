using HueCIT.Modules.NhaNhac_CMS.Interface;
using HueCIT.Modules.NhaNhac_CMS.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

using System.Drawing;


namespace HueCIT.Modules.NhaNhac_CMS.Services
{
    public class AnhApiController : ApiBaseController
    {
        private readonly IAnhRepository _anhRepository;
        public AnhApiController()
        {
            _anhRepository = new AnhRepository();
        }

        [System.Web.Http.HttpPost]

        public List<Object> Posts(string pathFolder, string pathThuMuc)
        {

            HttpFileCollection files = HttpContext.Current.Request.Files;
            List<Object> filesUrls = new List<object>();
            for (var i = 0; i < files.Count; i++)
            {
                try
                {
                    HttpPostedFile file = files[i];
                    var savePath = HttpContext.Current.Server.MapPath(pathFolder);
                    if (!Directory.Exists(savePath))
                        Directory.CreateDirectory(savePath);
                    string time = DateTime.Now.ToString("ddMMyyyyHHmmss");
                    string _filename = time + "_" + Path.GetFileName(file.FileName);
                    string _path = Path.Combine(savePath, _filename);
                    file.SaveAs(_path);
                    Uri baseuri = new Uri(Request.RequestUri.AbsoluteUri.Replace(Request.RequestUri.PathAndQuery, string.Empty));
                    var thuMuc = pathThuMuc;
                    var fileBase = $"{thuMuc}/{_filename}";
                    filesUrls.Add(new
                    {
                        url = fileBase,
                        filename = _filename
                    });
                }
                catch (Exception ex)
                {
                    throw (ex);
                }


            }

            return filesUrls;

        }

        [System.Web.Http.HttpPut]


        public List<Object> Puts(string pathFolder, string pathThuMuc, string nameImage)
        {

           string  Path1 =pathFolder + "/" + nameImage;

            //if ((System.IO.File.Exists(Path1)))
            //{
            //    System.IO.File.Delete(Path1);
            //}
            if (System.IO.File.Exists(HttpContext.Current.Server.MapPath(Path1)))
            {
                System.IO.File.Delete(HttpContext.Current.Server.MapPath(Path1));
            }
            //FileInfo filedelete = new FileInfo(Path1);
            //if (filedelete.Exists)
            //{
            //    filedelete.Delete();
            //}
            HttpFileCollection files = HttpContext.Current.Request.Files;
            List<Object> filesUrls = new List<object>();
            for (var i = 0; i < files.Count; i++)
            {
                try
                {
                    HttpPostedFile file = files[i];
                    var savePath = HttpContext.Current.Server.MapPath(pathFolder);
                    if (!Directory.Exists(savePath))
                        Directory.CreateDirectory(savePath);
                    string time = DateTime.Now.ToString("ddMMyyyyHHmmss");
                    string _filename = time + "_" + Path.GetFileName(file.FileName);
                    string _path = Path.Combine(savePath, _filename);
                    file.SaveAs(_path);
                    Uri baseuri = new Uri(Request.RequestUri.AbsoluteUri.Replace(Request.RequestUri.PathAndQuery, string.Empty));
                    var thuMuc = pathThuMuc;
                    var fileBase = $"{thuMuc}/{_filename}";
                    filesUrls.Add(new
                    {
                        url = fileBase,
                        filename = _filename
                    });
                }
                catch (Exception ex)
                {
                    throw (ex);
                }


            }

            return filesUrls;

        }


        [System.Web.Http.HttpGet]
        public async Task<HttpResponseMessage> Gets(string MaAnh)
        {
            try
            {
                Anh lst = new Anh();
                lst = await _anhRepository.Gets(MaAnh);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpPost]
        public async Task<HttpResponseMessage> anhPosts(string url, string filename)
        {
            try
            {
                Anh lst = new Anh();
                lst = await _anhRepository.Image(url, filename);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }

        [System.Web.Http.HttpPut]
        public async Task<HttpResponseMessage> Puts(Anh anh)
        {
            try
            {
                Anh lst = new Anh();
                lst = await _anhRepository.Puts(anh);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
        [System.Web.Http.HttpDelete]


        public HttpResponseMessage DeleteImage(string Path)
        {
            try
            {

                if (System.IO.File.Exists(HttpContext.Current.Server.MapPath(Path)))
                {
                    System.IO.File.Delete(HttpContext.Current.Server.MapPath(Path));
                }
                return Request.CreateResponse(HttpStatusCode.OK, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }


        }
        [System.Web.Http.HttpDelete]
        public async Task<HttpResponseMessage> Delete(int ID )
        {

            try
            {
                Anh lst = new Anh();
                lst = await _anhRepository.Delete(ID);
                return Request.CreateResponse(HttpStatusCode.OK, lst, "application/json");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, "Lỗi :" + ex.Message, "application/json");
            }
        }
    }
}
