using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaMoedas.Classes
{
    public class VantagemAluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código")]
        public int Codigo { get; set; }

        [Column(Order = 1)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Descrição")]
        public int CodigoAluno { get; set; }

        [Column(Order = 2)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Valor")]
        public int CodigoVantagem { get; set; }
    }
}
