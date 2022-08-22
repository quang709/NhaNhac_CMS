
using DotNetNuke.Web.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HueCIT.Modules.NhaNhac_CMS.Components
{
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes(IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute(
            "NhaNhac_CMS",
            "default",
            "{controller}/{action}",
            new[] { "HueCIT.Modules.NhaNhac_CMS.Services" });
        }
    }
}