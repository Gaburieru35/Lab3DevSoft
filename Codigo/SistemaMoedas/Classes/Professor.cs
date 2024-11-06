using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaMoedas.Classes
{
    public class Professor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public int CodigoProfessor { get; set; }

        [Column(Order = 1)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public int CpfProfessor { get; set; }

        [Column(Order = 2)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public int DepartamentoProfessor { get; set; }

        [Column(Order = 3)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public int InstituicaoProfessor { get; set; }

        [Column(Order = 4)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public int MoedasProfessor { get; set; }

        [Column(Order = 5)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public string NomeProfessor { get; set; }

        [Column(Order = 6)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public string EmailProfessor { get; set; }

        [Column(Order = 7)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public string SenhaProfessor { get; set; }
    }
}
