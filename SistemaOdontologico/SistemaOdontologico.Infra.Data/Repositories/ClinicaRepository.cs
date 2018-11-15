using SistemaOdontologico.Domain.Interfaces.Repositories;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Infra.Data.Repositories
{
    public class ClinicaRepository : RepositoryBase<Clinica>, IClinicaRepository
    {
        public IEnumerable<Clinica> BuscarPorNome(string Nome)
        {
            return Db.Clinicas.Where(x => x.Nome == Nome);
        }
    }
}
