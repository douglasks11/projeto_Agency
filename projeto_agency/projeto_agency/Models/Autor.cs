using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace projeto_agency.Models
{
    public class Autor
    {
        public int autorID { get; set; }
        [StringLength(50)]
        [Required(ErrorMessage = "Nome é Obrigatório")]
        public string nome { get; set; }

        [StringLength(12, ErrorMessage = "Senha deve ter 6 ou mais caracteres", MinimumLength = 6)]
        [MaxLength(12, ErrorMessage ="Senha não pode ter mais que 12 caracteres")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Senha é Obrigatório")]
        public string senha { get; set; }
        [StringLength(100)]
        [EmailAddress(ErrorMessage = "E-mail em formato inválido.")]
        [Required(ErrorMessage = "E-mail é Obrigatório")]
        public string email { get; set; }

        public virtual ICollection<Livro> Livros { get; set; }

    }
}