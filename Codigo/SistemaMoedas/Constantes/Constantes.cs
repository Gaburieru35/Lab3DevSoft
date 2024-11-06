using System.ComponentModel;

namespace SistemaMoedas.Constantes
{
    public class Constantes
    {
        public enum TiposUsuarios
        {
            [Description("Aluno")]
            Aluno = 1,
            [Description("Professor")]
            Professor = 2,
            [Description("Parceiro")]
            Parceiro = 3,
        }
    }
}
