using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.ViewModels.Radiografia
{
    public class CadastroViewModel
    {
        [Key]
        public long Id { get; set; }

        public long IdPaciente { get; set; }
        public long IdClinica { get; set; }
        public string Paciente { get; set; }
        public string Clinica { get; set; }
        [Required(ErrorMessage = "Preencha o campo data")]
        public string Data { get; set; }
        [Required(ErrorMessage = "Preencha o campo hora")]
        public string Hora { get; set; }
        [DisplayName("Observação")]
        public string Observacao { get; set; }
        public string LinkImg { get; set; }
    }
}
