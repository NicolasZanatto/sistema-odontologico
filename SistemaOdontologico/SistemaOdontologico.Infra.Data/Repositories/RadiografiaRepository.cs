using SistemaOdontologico.Domain.Interfaces.Repositories;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Infra.Data.Repositories
{
    public class RadiografiaRepository : RepositoryBase<Radiografia>, IRadiografiaRepository
    {
        public IEnumerable<Radiografia> BuscarPorIdPaciente(long id)
        {
            return Db.Radiografias.Where(x => x.IdPaciente == id);
        }
    }
}
