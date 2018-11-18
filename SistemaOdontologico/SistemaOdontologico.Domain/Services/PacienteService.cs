using SistemaOdontologico.Domain.Interfaces.Repositories;
using SistemaOdontologico.Domain.Interfaces.Services;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Domain.Services
{
    public class PacienteService : ServiceBase<Paciente>, IPacienteService
    {
        private readonly IPacienteRepository _pacienteRepository;

        public PacienteService(IPacienteRepository pacienteRepository)
            : base(pacienteRepository)
        {
            _pacienteRepository = pacienteRepository;
        }

        public IEnumerable<Paciente> BuscarPorNome(string nome)
        {
            return _pacienteRepository.BuscarPorNome(nome);
        }
    }
}
