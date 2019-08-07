using AutoMapper;
using SBMS.Models;
using SBMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SBMS
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            ConfigureAutomapper();
        }
        public void ConfigureAutomapper()
        {
            Mapper.Initialize(conf =>
            {
                conf.CreateMap<CategoryAddVM, Category>();
                conf.CreateMap<Category, CategoryAddVM>();
            });
        }
    }
}
