using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.ViewModels
{
    public class ClinicaViewModel
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome")]
        public string Nome { get; set; }
        public long IdUsuario { get; set; }
        public virtual UsuarioViewModel Usuario { get; set; }
    }
}
