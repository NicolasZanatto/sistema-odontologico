using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Domain.Interfaces
{
    public interface IClinicaRepository : IRepositoryBase<Clinica>
    {
        IEnumerable<Clinica> BuscarPorNome(string nome);
    }
}
