using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projeto_agency.Models
{
    public class Livro
    {
        public int livroID { get; set; }
        [MaxLength(50, ErrorMessage ="Nome muito longo")]
        [StringLength(50)]
        [Required(ErrorMessage = "Nome do livro é Obrigatório")]
        public string nome { get; set; }
        [StringLength(255)]
        [Required(ErrorMessage = "Descrição é Obrigatório")]
        public string descricao { get; set; }
        [Required(ErrorMessage ="É necessario cadastrar um Autor")]
        public int autorID { get; set; }
        [ForeignKey("autorID")]
        public virtual Autor autor { get; set; }

    }
}