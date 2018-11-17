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

            profile.CreateMap<Clinica, CadastroViewModel>()
                .ForMember(x => x.Nome, m => m.MapFrom(o => o.Nome))
                .ForMember(x => x.Login, m => m.MapFrom(o => o.Usuario.Login))
                .ForMember(x => x.Senha, m => m.MapFrom(o => o.Usuario.Senha))
                .ForMember(x => x.Ativo, m => m.MapFrom(o => o.Usuario.Ativo));
        }
    }
}
