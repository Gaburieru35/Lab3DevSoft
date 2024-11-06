using SistemaMoedas.Classes;

namespace SistemaMoedas.Model
{
    public class ListagemExtratoModel 
    {
        public List<Transferencia> Transferencias { get; set; }
        public Constantes.Constantes.TiposUsuarios TiposUsuarios { get; set; }
        public int IdUsuario {  get; set; }
    }
}
