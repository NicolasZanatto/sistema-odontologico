using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.ViewModels.Radiografia
{
    public class ListagemViewModel
    {
        [Key]
        public long Id { get; set; }
        public long IdPaciente { get; set; }
        public string Paciente { get; set; }

        [DisplayName("Clínica")]
        public string Clinica { get; set; }
        public string Data { get; set; }
        public string Hora { get; set; }
    }
}
