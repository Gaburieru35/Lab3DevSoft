using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaMoedas.Classes
{
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public int CodigoCurso { get; set; }

        [Column(Order = 1)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public string NomeCurso { get; set; }
    }
}
