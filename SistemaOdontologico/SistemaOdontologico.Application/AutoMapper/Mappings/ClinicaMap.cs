using SistemaOdontologico.Application.ViewModels.Clinica;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.AutoMapper.Mappings
{
    public sealed class ClinicaMap
    {
        public static void Map(ViewModelToDomainMappingProfile profile)
        {
            profile.CreateMap<CadastroViewModel, Clinica>()
                .ForMember(x => x.IdUsuario, m => m.MapFrom(o => o.Usuario.Id));
        }
        public static void Map(DomainToViewModelMappingProfile profile)
        {
            profile.CreateMap<Clinica, ListagemViewModel>();
        }
    }
}
