using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaMoedas.Classes
{
    public class Vantagem
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código")]
        public int CodigoVantagem { get; set; }

        [Column(Order = 1)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Descrição")]
        public string DescricaoVantagem { get; set; }

        [Column(Order = 2)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Valor")]
        public int ValorVantagem { get; set; }

        [Column(Order = 3)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Título")]
        public string TituloVantagem { get; set; }
    }
}
