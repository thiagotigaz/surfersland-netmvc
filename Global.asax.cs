using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using SurfersLand.App_Data;

namespace SurfersLand
{
    public class MvcApplication : System.Web.HttpApplication
    {
        public static IMapper Mapper;
        
        protected void Application_Start()
        {
            Mapper = new MapperConfiguration(cfg => {
                cfg.AddProfile<MappingProfile>();
            }).CreateMapper();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
