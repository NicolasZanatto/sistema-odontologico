using SistemaOdontologico.Application.ViewModels.Usuario;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.Interface
{
    public interface IUsuarioAppService : IDisposable
    {
        void Add(UsuarioViewModel usuarioViewModel);
        void Update(UsuarioViewModel usuarioViewModel);
        void Remove(long id);
        UsuarioViewModel GetById(long id);
        IEnumerable<UsuarioViewModel> GetAll();
    }
}
