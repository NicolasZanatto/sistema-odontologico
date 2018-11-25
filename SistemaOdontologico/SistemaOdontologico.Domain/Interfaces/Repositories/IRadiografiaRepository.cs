﻿using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Domain.Interfaces.Repositories
{
    public interface IRadiografiaRepository : IRepositoryBase<Radiografia>  
    {
        IEnumerable<Radiografia> BuscarPorIdPaciente(long id);
    }
}
