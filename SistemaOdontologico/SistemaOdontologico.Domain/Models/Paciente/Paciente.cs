using SistemaOdontologico.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Domain.Models
{
    public partial class Paciente
    {
        public Paciente()
        {

        }
        public Paciente(long id)
        {
            Id = id;
        }
        public long Id { get; set; }
        public string Nome { get; set; }
        public eTipoSexo TipoSexo { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public long IdUsuario { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
