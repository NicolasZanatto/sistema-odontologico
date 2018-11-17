using SimpleInjector;
using SistemaOdontologico.Domain.Interfaces.Repositories;
using SistemaOdontologico.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Infra.IoC.Modules
{
    public static class RepositoryModule
    {
        public static void Register(Container container)
        {
            //container.Register(typeof(IRepositoryBase<>), typeof(IRepositoryBase<>).Assembly);
            container.Register<IUsuarioRepository, UsuarioRepository>(Lifestyle.Scoped);
            container.Register<IClinicaRepository, ClinicaRepository>(Lifestyle.Scoped);
        }
    }
}
