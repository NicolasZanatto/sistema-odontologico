using AutoMapper;
using SistemaOdontologico.Application.AutoMapper.Mappings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        public ViewModelToDomainMappingProfile()
        {
            UsuarioMap.Map(this);
            ClinicaMap.Map(this);
            PacienteMap.Map(this);
            RadiografiaMap.Map(this);
        }
    }
}
