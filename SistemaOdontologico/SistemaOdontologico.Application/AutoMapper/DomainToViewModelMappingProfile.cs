using AutoMapper;
using SistemaOdontologico.Application.AutoMapper.Mappings;
using SistemaOdontologico.Application.ViewModels;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "DomainToViewModelMappings"; }
        }

        public DomainToViewModelMappingProfile()
        {
            UsuarioMap.Map(this);
            ClinicaMap.Map(this);
        }
    }
}
