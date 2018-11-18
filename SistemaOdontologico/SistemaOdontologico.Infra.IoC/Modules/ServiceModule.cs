using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleInjector;
using SistemaOdontologico.Domain.Interfaces.Services;
using SistemaOdontologico.Domain.Services;

namespace SistemaOdontologico.Infra.IoC.Modules
{
    public static class ServiceModule
    {
        public static void Register(Container container)
        {
            container.Register<IUsuarioService, UsuarioService>(Lifestyle.Scoped);
            container.Register<IClinicaService, ClinicaService>(Lifestyle.Scoped);
            container.Register<IPacienteService, PacienteService>(Lifestyle.Scoped);
        }
    }
}
