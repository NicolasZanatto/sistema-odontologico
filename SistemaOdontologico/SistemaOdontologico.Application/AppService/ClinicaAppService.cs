using SistemaOdontologico.Application.Interface;
using SistemaOdontologico.Domain.Interfaces.Services;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.AppService
{
    public class ClinicaAppService : AppServiceBase<Clinica>, IClinicaAppService
    {
        private readonly IClinicaService _clinicaService;

        public ClinicaAppService(IClinicaService clinicaService)
            : base(clinicaService)
        {
            _clinicaService = clinicaService;
        }

        public IEnumerable<Clinica> BuscarPorNome(string nome)
        {
            return _clinicaService.BuscarPorNome(nome);
        }
    }
}
