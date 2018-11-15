using SistemaOdontologico.Application.ViewModels;
using SistemaOdontologico.Application.ViewModels.Usuario;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.AutoMapper.Mappings
{
    public sealed class UsuarioMap
    {
        public static void Map(ViewModelToDomainMappingProfile profile)
        {
            profile.CreateMap<UsuarioViewModel, Usuario>();               
        }
        public static void Map(DomainToViewModelMappingProfile profile)
        {
            profile.CreateMap<Usuario, UsuarioViewModel>();
        }
    }
}
