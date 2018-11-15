using SistemaOdontologico.Domain.Interfaces.Repositories;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Domain.Services
{
    public class ClinicaService : ServiceBase<Clinica>, IClinicaRepository
    {
        private readonly IClinicaRepository _clinicaRepository;

        public ClinicaService(IClinicaRepository clinicaRepository)
            : base(clinicaRepository)
        {
            _clinicaRepository = clinicaRepository;
        }

        public IEnumerable<Clinica> BuscarPorNome(string nome)
        {
            return _clinicaRepository.BuscarPorNome(nome);
        }
    }
}
