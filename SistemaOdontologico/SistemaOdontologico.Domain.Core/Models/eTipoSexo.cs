using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Domain.Core.Models
{
    public enum eTipoSexo
    {
        [Description("Masculino")]
        Masculino = 1,
        [Description("Feminino")]
        Feminino = 2
    }
}
