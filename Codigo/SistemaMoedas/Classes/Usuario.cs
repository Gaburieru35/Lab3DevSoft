using static SistemaMoedas.Constantes.Constantes;

namespace SistemaMoedas.Classes
{
    public class Usuario
    {
        public int? IdUsuario { get; set; }
        public TiposUsuarios? TipoUsuario {  get; set; }
        public string? EmailUsuario { get; set; }
        public string? NomeUsuario { get; set; }
    }
}
