using SistemaMoedas.Classes;

namespace SistemaMoedas.Services.Interfaces
{
    public interface IVantagemService
    {
        public void Incluir(Vantagem vantagem);

        public IList<Vantagem> ListarTodos();
    }
}
