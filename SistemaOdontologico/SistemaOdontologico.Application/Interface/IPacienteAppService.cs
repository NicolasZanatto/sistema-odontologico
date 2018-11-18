﻿using SistemaOdontologico.Application.ViewModels.Paciente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.Interface
{
    public interface IPacienteAppService : IDisposable
    {
        void Add(CadastroViewModel cadastroViewModel);
        void Update(CadastroViewModel cadastroViewModel);
        void Remove(long id);
        CadastroViewModel GetById(long id);
        IEnumerable<ListagemViewModel> GetAll();
        IEnumerable<ListagemViewModel> GetByName(string nome);
    }
}