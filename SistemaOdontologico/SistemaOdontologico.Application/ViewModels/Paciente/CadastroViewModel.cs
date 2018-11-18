using SistemaOdontologico.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Application.ViewModels.Paciente
{
    public class CadastroViewModel
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Preencha o campo nome")]
        [MaxLength(150, ErrorMessage = "Máximo {0} caracteres")]
        [MinLength(2, ErrorMessage = "Mínimo {0} caracteres")]
        public string Nome { get; set; }

        public eTipoSexo Sexo { get; set; }

        [Required(ErrorMessage = "Preencha o campo idade")]
        [Range(0,100)]
        public int Idade { get; set; }

        [Required(ErrorMessage = "Preencha o campo telefone")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Preencha o campo e-mail")]
        [DisplayName("E-mail:")]
        [EmailAddress]
        public string Email { get; set; }

        [DisplayName("Observação")]
        public string Observacao { get; set; }
        
        [Required(ErrorMessage = "Preencha o campo login")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Preencha o campo senha")]
        [PasswordPropertyText]
        public string Senha { get; set; }        

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }
        public long IdUsuario { get; set; }

        public Domain.Models.Usuario Usuario { get; set; }

    }
}
