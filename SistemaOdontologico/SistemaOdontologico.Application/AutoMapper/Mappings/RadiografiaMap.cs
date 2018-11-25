using SistemaOdontologico.Application.ViewModels.Radiografia;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.AutoMapper.Mappings
{
    public sealed class RadiografiaMap
    {
        public static void Map(ViewModelToDomainMappingProfile profile)
        {
            profile.CreateMap<CadastroViewModel, Radiografia>()
                .ForMember(x => x.Data, m => m.MapFrom(o => DateTime.Parse(o.Data)))
                .ForMember(x => x.Hora, m => m.MapFrom(o => DateTime.ParseExact(o.Hora, "HH:mm", CultureInfo.InvariantCulture)));
        }

        public static void Map(DomainToViewModelMappingProfile profile)
        {
            profile.CreateMap<Radiografia, CadastroViewModel>()
                .ForMember(x => x.Clinica, m => m.MapFrom(o => o.Clinica.Nome))
                .ForMember(x => x.Paciente, m => m.MapFrom(o => o.Paciente.Nome))
                .ForMember(x => x.Data, m => m.MapFrom(o => o.Data.ToString("dd/MM/yyyy")))
                .ForMember(x => x.Hora, m => m.MapFrom(o => o.Hora.ToString("HH:mm")));

            profile.CreateMap<Radiografia, ListagemViewModel>()
                .ForMember(x => x.Paciente, m => m.MapFrom(o => o.Paciente.Nome))
                .ForMember(x => x.Clinica, m => m.MapFrom(o => o.Clinica.Nome))
                .ForMember(x => x.Data, m => m.MapFrom(o => o.Data.ToString("dd/MM/yyyy")))
                .ForMember(x => x.Hora, m => m.MapFrom(o => o.Hora.ToString("HH:mm")));
        }
    }
}
