using DotNetNuke.Web.Mvc.Framework.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace HueCIT.Modules.NhaNhac_CMS.Controllers
{
    public class NgheNghiepController : DnnController
    {

        public ActionResult Index()
        {
            return View();
        }
    }
}
