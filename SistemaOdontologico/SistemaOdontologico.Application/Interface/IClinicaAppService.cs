using SistemaOdontologico.Application.ViewModels.Clinica;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.Interface
{
    public interface IClinicaAppService : IDisposable
    {
        void Add(CadastroViewModel cadastroViewModel);
        void Update(CadastroViewModel cadastroViewModel);
        void Remove(long id);
        CadastroViewModel GetById(long id);
        IEnumerable<ListagemViewModel> GetAll();
        IEnumerable<CadastroViewModel> GetByName(string nome);
    }
}
