using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Domain.Interfaces.Services
{
    public interface IPacienteService : IServiceBase<Paciente>
    {
        IEnumerable<Paciente> BuscarPorNome(string nome);
    }
}
