using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SistemaMoedas.Interfaces;

namespace SistemaMoedas.Classes
{
    public class Parceiro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public int CodigoParceiro { get; set; }

        [Column(Order = 1)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public string NomeParceiro { get; set; }

        [Column(Order = 2, TypeName = "VARCHAR")]
        [StringLength(22)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public string CnpjParceiro { get; set; }

        [Column(Order = 3, TypeName = "VARCHAR")]
        [DataType(DataType.Text)]
        [StringLength(100)]
        [Required(ErrorMessage = "Email não informado")]
        [Display(Name = "Email")]
        public string EmailParceiro { get; set; }

        [Column(Order = 4, TypeName = "VARCHAR")]
        [DataType(DataType.Text)]
        [StringLength(50)]
        [Required(ErrorMessage = "Senha não informado")]
        [Display(Name = "Senha")]
        public string SenhaParceiro { get; set; }

        [Column(Order = 8)]
        [DataType(DataType.DateTime)]
        [Display(Name = "Data cadastro")]
        public DateTime DataCadastroParceiro { get; set; }
    }
}
