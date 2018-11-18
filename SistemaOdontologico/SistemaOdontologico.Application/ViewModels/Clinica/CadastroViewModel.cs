using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SistemaOdontologico.Application.ViewModels.Clinica
{
    public class CadastroViewModel
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
        public long IdUsuario { get; set; }
        public Domain.Models.Usuario Usuario { get; set; }

    }
}
