using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Domain.Models
{
    public partial class Clinica
    {
        public Clinica()
        {

        }
        public Clinica(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
        public string Nome { get; set; }
        public long IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
