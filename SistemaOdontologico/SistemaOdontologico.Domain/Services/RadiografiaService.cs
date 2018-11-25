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
    public class RadiografiaService : ServiceBase<Radiografia>, IRadiografiaService
    {
        private readonly IRadiografiaRepository _radiografiaRepository;

        public RadiografiaService(IRadiografiaRepository radiografiaRepository)
            : base(radiografiaRepository)
        {
            _radiografiaRepository = radiografiaRepository;
        }

        public IEnumerable<Radiografia> BuscarPorIdPaciente(long id)
        {
            return _radiografiaRepository.BuscarPorIdPaciente(id).ToList();
        }
    }
}
