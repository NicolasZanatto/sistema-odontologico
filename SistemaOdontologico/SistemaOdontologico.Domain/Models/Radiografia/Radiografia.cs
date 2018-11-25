using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Domain.Models
{
    public partial class Radiografia
    {
        public Radiografia()
        {

        }

        public Radiografia(long id)
        {
            Id = id;
        }

        public long Id { get; set; }
        public long IdPaciente { get; set; }
        public long IdClinica { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual Clinica Clinica { get; set; }
        public DateTime Data { get; set; }
        public DateTime Hora { get; set; }
        public string Observacao { get; set; }
        public string LinkImg { get; set; }

    }
}
