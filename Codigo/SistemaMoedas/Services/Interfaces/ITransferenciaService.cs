using SistemaMoedas.Classes;

namespace SistemaMoedas.Services.Interfaces
{
    public interface ITransferenciaService
    {
        public void incluir(Transferencia transferencia);
        public IList<Transferencia> Transferencias();
    }
}
