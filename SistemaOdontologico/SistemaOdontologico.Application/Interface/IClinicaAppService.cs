using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.Interface
{
    public interface IClinicaAppService : IAppServiceBase<Clinica>
    {
        IEnumerable<Clinica> BuscarPorNome(string nome);
    }
}
