using SistemaOdontologico.Domain.Interfaces.Repositories;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Infra.Data.Repositories
{
    public class PacienteRepository : RepositoryBase<Paciente>, IPacienteRepository
    {
        public IEnumerable<Paciente> BuscarPorNome(string Nome)
        {
            return Db.Pacientes.Where(x => x.Nome == Nome);
        }
    }
}
