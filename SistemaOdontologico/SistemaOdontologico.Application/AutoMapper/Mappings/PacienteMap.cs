using SistemaOdontologico.Application.ViewModels.Paciente;
using SistemaOdontologico.Domain.Core.Extensions;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.AutoMapper.Mappings
{
    public sealed class PacienteMap
    {
        public static void Map(ViewModelToDomainMappingProfile profile)
        {
            profile.CreateMap<CadastroViewModel, Paciente>()
                .ForMember(x => x.IdUsuario, m => m.MapFrom(o => o.IdUsuario))
                .ForMember(x => x.TipoSexo, m => m.MapFrom(o => o.Sexo));
        }

        public static void Map(DomainToViewModelMappingProfile profile)
        {
            profile.CreateMap<Paciente, ListagemViewModel>()
                .ForMember(x => x.Sexo, m => m.MapFrom(o => o.TipoSexo.ToString()));

            profile.CreateMap<Paciente, CadastroViewModel>()
                .ForMember(x => x.IdUsuario, m => m.MapFrom(o => o.IdUsuario))
                .ForMember(x => x.Nome, m => m.MapFrom(o => o.Nome))
                .ForMember(x => x.Login, m => m.MapFrom(o => o.Usuario.Login))
                .ForMember(x => x.Senha, m => m.MapFrom(o => o.Usuario.Senha))
                .ForMember(x => x.Ativo, m => m.MapFrom(o => o.Usuario.Ativo));
        }
    }
}
