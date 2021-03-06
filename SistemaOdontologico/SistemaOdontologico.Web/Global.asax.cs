﻿using SistemaOdontologico.Application.AutoMapper;
using SimpleInjector.Integration.Web.Mvc;
using SistemaOdontologico.Infra.IoC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace SistemaOdontologico.Web
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AutoMapperConfig.RegisterMappings();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(SimpleInjectorContainer.RegisterServices()));
        }
    }
}
