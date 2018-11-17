using SimpleInjector;
using SistemaOdontologico.Application.AppService;
using SistemaOdontologico.Application.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Infra.IoC.Modules
{
    public static class ApplicationServiceModule
    {
        public static void Register(Container container)
        {
            container.Register<IUsuarioAppService, UsuarioAppService>(Lifestyle.Scoped);
            container.Register<IClinicaAppService, ClinicaAppService>(Lifestyle.Scoped);
        }
    }
}
