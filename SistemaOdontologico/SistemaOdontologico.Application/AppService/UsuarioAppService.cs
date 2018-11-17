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
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public UsuarioViewModel GetById(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UsuarioViewModel> GetByName(string nome)
        {
            throw new NotImplementedException();
        }

        public void Remove(UsuarioViewModel usuarioViewModel)
        {
            throw new NotImplementedException();
        }

        public void Update(UsuarioViewModel usuarioViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
