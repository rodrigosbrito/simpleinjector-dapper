using Business;
using Business.Interfaces;
using Data;
using DevBrito.TesteSimpleInjector.Mappers;
using SimpleInjector;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace DevBrito.TesteSimpleInjector
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            // Configurando o AutoMapper para registrar os profiles
            // de mapeamento durante a inicialização da aplicação.
            AutoMapperConfig.RegisterMappings();

            // 1. Create a new Simple Injector container
            var container = new Container();

            // 2. Configure the container (register)
            // See below for more configuration examples
            container.Register<IMarcaService, MarcaService>(Lifestyle.Transient);
            container.Register<IMarcaRepository, MarcaRepository>(Lifestyle.Singleton);

            // 3. Optionally verify the container's configuration.
            container.Verify();

            // 4. Store the container for use by the application
            DependencyResolver.SetResolver(
                new SimpleInjectorDependencyResolver(container));
        }
    }
}