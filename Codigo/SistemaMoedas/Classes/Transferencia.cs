using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using SistemaMoedas.Interfaces;

namespace SistemaMoedas.Classes
{
    public class Transferencia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(Order = 0)]
        public int CodigoTransferencia { get; set; }

        // Chave estrangeira para OrigemTransferencia (Professor)
        [Required(ErrorMessage = "Código do professor de origem não informado")]
        [Display(Name = "Código do professor de origem")]
        [ForeignKey("OrigemTransferencia")]
        public int OrigemTransferenciaCodigoProfessor { get; set; }
        
        public Professor OrigemTransferencia { get; set; } // Propriedade de navegação

        // Chave estrangeira para DestinoTransferencia (Aluno)
        [Required(ErrorMessage = "Código do aluno de destino não informado")]
        [Display(Name = "Código do aluno de destino")]
        [ForeignKey("DestinoTransferencia")]
        public int DestinoTransferenciaCodigoAluno { get; set; }
        
        public Aluno DestinoTransferencia { get; set; } // Propriedade de navegação

        [Required(ErrorMessage = "Data e hora da transferência não informadas")]
        [Display(Name = "Data e hora da transferência")]
        public DateTime DataHoraTransferencia { get; set; }

        [Required(ErrorMessage = "Valor da transferência não informado")]
        [Display(Name = "Valor da transferência")]
        public int ValorTransferencia { get; set; }

        [Required(ErrorMessage = "Tipo da transferência não informado")]
        [Display(Name = "Tipo da transferência")]
        public int TipoTransferencia { get; set; }
    }
}
