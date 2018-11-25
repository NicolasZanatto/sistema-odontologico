using AutoMapper;
using SistemaOdontologico.Application.Interface;
using SistemaOdontologico.Application.ViewModels.Radiografia;
using SistemaOdontologico.Domain.Interfaces.Services;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.AppService
{
    public class RadiografiaAppService : IRadiografiaAppService
    {
        private readonly IRadiografiaService _radiografiaService;
        private readonly IPacienteService _pacienteService;
        private readonly IClinicaService _clinicaService;
        public RadiografiaAppService(IRadiografiaService radiografiaService, IPacienteService pacienteService, IClinicaService clinicaService)
        {
            _radiografiaService = radiografiaService;
            _pacienteService = pacienteService;
            _clinicaService = clinicaService;
        }

        public void Add(CadastroViewModel cadastroViewModel)
        {
            _radiografiaService.Add(Mapper.Map<CadastroViewModel, Radiografia>(cadastroViewModel));
        }

        public void Update(CadastroViewModel cadastroViewModel)
        {
            _radiografiaService.Update(Mapper.Map<CadastroViewModel, Radiografia>(cadastroViewModel));
        }

        public void Remove(long id)
        {
            var radiografia = _radiografiaService.GetById(id);
            _radiografiaService.Remove(radiografia);
        }

        public CadastroViewModel GetById(long id)
        {
            var radiografia = _radiografiaService.GetById(id);
            radiografia.Paciente = _pacienteService.GetById(radiografia.IdPaciente);
            radiografia.Clinica = _clinicaService.GetById(radiografia.IdClinica);

            return Mapper.Map<Radiografia, CadastroViewModel>(radiografia);
        }

        public IEnumerable<ListagemViewModel> BuscarPorIdPaciente(long id)
        {
            var radiografias = _radiografiaService.BuscarPorIdPaciente(id);
            return Mapper.Map<IEnumerable<Radiografia>, IEnumerable<ListagemViewModel>>(radiografias);
        }
    }
}
