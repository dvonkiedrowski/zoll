using AutoMapper;
using System;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Zoll.Dtos;
using Zoll.Dtos.Base;

namespace Zoll
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Mapper.Initialize(cfg => {
                cfg.CreateMap<Zoll, ZollDto>();
                cfg.CreateMap<ZollDto, Zoll>();
                cfg.CreateMap<Filiale, BaseDtoWithName>();
                cfg.CreateMap<Min_Steu, MinSteuDto>();
            });

            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
