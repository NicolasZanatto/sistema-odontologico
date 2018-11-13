using SistemaOdontologico.Domain.Core.Models;
using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public long Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo login")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Preencha o campo login")]
        public string Senha { get; set; }
        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }
        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }
        public eTipoUsuario TipoUsuario { get; set; }
        public virtual IEnumerable<ClinicaViewModel> Clinicas { get; set; }
    }
}
