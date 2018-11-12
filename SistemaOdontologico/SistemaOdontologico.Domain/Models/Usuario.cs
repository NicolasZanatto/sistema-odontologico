using SistemaOdontologico.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Domain.Models
{
    public class Usuario
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public eTipoUsuario TipoUsuario { get; set; }
        public virtual IEnumerable<Clinica> Clinicas { get; set; }

    }
}
