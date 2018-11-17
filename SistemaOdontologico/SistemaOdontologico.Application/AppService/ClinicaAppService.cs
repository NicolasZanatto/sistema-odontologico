using AutoMapper;
using SistemaOdontologico.Application.Interface;
using SistemaOdontologico.Application.ViewModels.Clinica;
using SistemaOdontologico.Application.ViewModels.Usuario;
using SistemaOdontologico.Domain.Core.Models;
using SistemaOdontologico.Domain.Interfaces.Services;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.AppService
{
    public class ClinicaAppService : IClinicaAppService
    {
        private readonly IClinicaService _clinicaService;
        private readonly IUsuarioService _usuarioService;

        public ClinicaAppService(IClinicaService clinicaService, IUsuarioService usuarioService)
        {
            _clinicaService = clinicaService;
            _usuarioService = usuarioService;
        }

        public void Add(CadastroViewModel clinicaViewModel)
        {
         
            clinicaViewModel.Usuario = Usuario.CriarNovo
                (
                    clinicaViewModel.Nome,
                    clinicaViewModel.Login,
                    clinicaViewModel.Senha,
                    eTipoUsuario.Clinica,
                    clinicaViewModel.Ativo
                );

            var clinicaDomain = Mapper.Map<CadastroViewModel, Clinica>(clinicaViewModel);
            _clinicaService.Add(clinicaDomain);
        }

        public void Update(CadastroViewModel clinicaViewModel)
        {
            var clinica = Mapper.Map<CadastroViewModel, Clinica>(clinicaViewModel);
            _clinicaService.Update(clinica);
        }

        public void Remove(long id)
        {
            var clinica = _clinicaService.GetById(id);
            _clinicaService.Remove(clinica);
        }

        public IEnumerable<ListagemViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Clinica>, IEnumerable<ListagemViewModel>>(_clinicaService.GetAll());
        }

        public CadastroViewModel GetById(long id)
        {
            var clinica = _clinicaService.GetById(id);
            clinica.Usuario = _usuarioService.GetById(clinica.IdUsuario);

            return Mapper.Map<Clinica, CadastroViewModel>(clinica);
        }

        public IEnumerable<CadastroViewModel> GetByName(string nome)
        {
            var clinica = _clinicaService.BuscarPorNome(nome);
            return Mapper.Map<IEnumerable<Clinica>, IEnumerable<CadastroViewModel>>(clinica);
        }
       
        public void Dispose()
        {
            _clinicaService.Dispose();
        }
    }
}
