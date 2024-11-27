using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SistemaMoedas.Interfaces;

namespace SistemaMoedas.Classes
{
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public int CodigoAluno { get; set; }

        [Column(Order = 1, TypeName = "VARCHAR")]
        [DataType(DataType.Text)]
        [StringLength(100)]
        [Required(ErrorMessage = "Email não informado")]
        [Display(Name = "Email")]
        public string EmailAluno { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR")]
        [DataType(DataType.Text)]
        [StringLength(100)]
        [Required(ErrorMessage = "Endereço não informado")]
        [Display(Name = "Endereço")]
        public string EnderecoAluno { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR")]
        [DataType(DataType.Text)]
        [StringLength(14)]
        [Required(ErrorMessage = "CPF não informado")]
        [Display(Name = "CPF")]
        public string CpfAluno { get; set; }

        [Column(Order = 4, TypeName = "VARCHAR")]
        [DataType(DataType.Text)]
        [StringLength(8)]
        [Required(ErrorMessage = "RG não informado")]
        [Display(Name = "RG")]
        public string RGAluno { get; set; }

        [Column(Order = 5, TypeName = "VARCHAR")]
        [DataType(DataType.Text)]
        [StringLength(100)]
        [Required(ErrorMessage = "Nome não informado")]
        [Display(Name = "Nome")]
        public string NomeAluno { get; set; }

        [Column(Order = 6, TypeName = "VARCHAR")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        [Required(ErrorMessage = "Senha não informado")]
        [Display(Name = "Senha")]
        public string SenhaAluno { get; set; }

        [Column(Order = 7)]
        [DataType(DataType.Currency)]
        [Required(ErrorMessage = "QuantidadeMoedas")]
        [Display(Name = "Moedas")]
        public int QuantidadeMoedasAluno { get; set; }

        [Column(Order = 8)]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data cadastro")]
        public DateTime DataCadastroAluno { get; set; }

        [Column(Order = 9)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Instituição de ensino")]
        [Display(Name = "Instituição")]
        public int InstituicaoAluno { get; set; }

        [Column(Order = 10)]
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Curso")]
        [Display(Name = "Curso")]
        public int CursoAluno { get; set; }
    }
}
