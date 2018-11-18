using AutoMapper;
using SistemaOdontologico.Application.Interface;
using SistemaOdontologico.Application.ViewModels.Paciente;
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
    public class PacienteAppService : IPacienteAppService
    {
        private readonly IPacienteService _pacienteService;
        private readonly IUsuarioService _usuarioService;

        public PacienteAppService(IPacienteService pacienteService, IUsuarioService usuarioService)
        {
            _pacienteService = pacienteService;
            _usuarioService = usuarioService;
        }

        public void Add(CadastroViewModel cadastroViewModel)
        {
            cadastroViewModel.Usuario = Usuario.CriarNovo
                (
                    cadastroViewModel.Nome,
                    cadastroViewModel.Login,
                    cadastroViewModel.Senha,
                    eTipoUsuario.Paciente,
                    cadastroViewModel.Ativo
                );

            var paciente = Mapper.Map<CadastroViewModel, Paciente>(cadastroViewModel);
            _pacienteService.Add(paciente);
        }

        public void Update(CadastroViewModel cadastroViewModel)
        {
            cadastroViewModel.Usuario = Usuario.Criar
                (
                    cadastroViewModel.IdUsuario,
                    cadastroViewModel.Nome,
                    cadastroViewModel.Login,
                    cadastroViewModel.Senha,
                    eTipoUsuario.Paciente,
                    cadastroViewModel.Ativo
                );

            _usuarioService.Update(cadastroViewModel.Usuario);

            var paciente = Mapper.Map<CadastroViewModel, Paciente>(cadastroViewModel);
            _pacienteService.Update(paciente);
        }

        public void Remove(long id)
        {
            var paciente = _pacienteService.GetById(id);
            _pacienteService.Remove(paciente);
        }        

        public IEnumerable<ListagemViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Paciente>, IEnumerable<ListagemViewModel>>(_pacienteService.GetAll());
        }

        public CadastroViewModel GetById(long id)
        {
            var paciente = _pacienteService.GetById(id);
            paciente.Usuario = _usuarioService.GetById(paciente.IdUsuario);

            return Mapper.Map<Paciente, CadastroViewModel>(paciente);
        }

        public IEnumerable<ListagemViewModel> GetByName(string nome)
        {
            var paciente = _pacienteService.BuscarPorNome(nome);
            return Mapper.Map<IEnumerable<Paciente>, IEnumerable<ListagemViewModel>>(paciente);
        }

        public void Dispose()
        {
            _pacienteService.Dispose();
        }

    }
}
