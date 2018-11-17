using SimpleInjector;
using SimpleInjector.Integration.Web;
using SistemaOdontologico.Infra.IoC.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Infra.IoC
{
    public static class SimpleInjectorContainer
    {
        public static Container RegisterServices()
        {

            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle() ;
           // container.GetAllInstances()
            MapperModules(container);
            container.Verify();

            return container;
        }

        public static void MapperModules(Container container)
        {
            ApplicationServiceModule.Register(container);
            RepositoryModule.Register(container);
            ServiceModule.Register(container);
        }
    }
}
