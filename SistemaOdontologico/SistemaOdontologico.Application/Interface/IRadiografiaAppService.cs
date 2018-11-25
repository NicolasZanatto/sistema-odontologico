using SistemaOdontologico.Application.ViewModels.Radiografia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.Interface
{
    public interface IRadiografiaAppService
    {
        void Add(CadastroViewModel cadastroViewModel);
        void Update(CadastroViewModel cadastroViewModel);
        void Remove(long id);
        CadastroViewModel GetById(long id);
        IEnumerable<ListagemViewModel> BuscarPorIdPaciente(long id);
    }
}
