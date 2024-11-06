using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SistemaMoedas.Classes
{
    public class Transferencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public int CodigoTransferencia { get; set; }

        [Column(Order = 1)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public int OrigemTransferencia { get; set; }

        [Column(Order = 2)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public int DestinoTransferencia { get; set; }

        [Column(Order = 3)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public DateTime DataHoraTransferencia { get; set; }

        [Column(Order = 4)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public int ValorTransferencia { get; set; }

        [Column(Order = 5)]
        [Required(ErrorMessage = "Código do aluno não informado")]
        [Display(Name = "Código aluno")]
        public int TipoTransferencia { get; set; }
    }
}
