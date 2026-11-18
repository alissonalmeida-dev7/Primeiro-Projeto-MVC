using System.ComponentModel.DataAnnotations;

namespace PrimeiroProjetoMVC.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "Nome deve ter entre 2 e 50 caracteres.")]
        [Required(ErrorMessage = "O nome é obrigatorio.")]
        public string Nome { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "O email é obrigatorio.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; } = "";
        
        [Range(16, 100, ErrorMessage = "Idade deve ser entre 16 e 100.")]
        public int Idade { get; set; }
    }
}