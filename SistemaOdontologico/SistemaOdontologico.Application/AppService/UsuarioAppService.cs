using AutoMapper;
using SistemaOdontologico.Application.Interface;
using SistemaOdontologico.Application.ViewModels.Usuario;
using SistemaOdontologico.Domain.Interfaces.Services;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.AppService
{
    public class UsuarioAppService : IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public void Add(UsuarioViewModel usuarioViewModel)
        {
            var usuario = Mapper.Map<UsuarioViewModel, Usuario>(usuarioViewModel);
            _usuarioService.Add(usuario);
        }

        public IEnumerable<UsuarioViewModel> BuscarTodos()
        {
            return Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioService.GetAll());
        }

        public void Dispose()
        {
            _usuarioService.Dispose();
        }

        public IEnumerable<UsuarioViewModel> GetAll()
        {
            return Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioService.GetAll());
        }

        public UsuarioViewModel GetById(long id)
        {
            var usuario = _usuarioService.GetById(id);
            return Mapper.Map<Usuario, UsuarioViewModel>(usuario);
        }

        public void Remove(long id)
        {
            var usuario = _usuarioService.GetById(id);
            _usuarioService.Remove(usuario);
        }

        public void Update(UsuarioViewModel usuarioViewModel)
        {
            var usuario = Mapper.Map<UsuarioViewModel, Usuario>(usuarioViewModel);
            _usuarioService.Update(usuario);
        }
    }
}
