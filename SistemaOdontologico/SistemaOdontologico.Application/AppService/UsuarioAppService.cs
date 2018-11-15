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
    public class UsuarioAppService : AppServiceBase<Usuario>, IUsuarioAppService
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioAppService(IUsuarioService usuarioService)
            : base(usuarioService)
        {
            _usuarioService = usuarioService;
        }

        public IEnumerable<UsuarioViewModel> BuscarTodos()
        {
            return Mapper.Map<IEnumerable<Usuario>, IEnumerable<UsuarioViewModel>>(_usuarioService.GetAll());
        }
    }
}
