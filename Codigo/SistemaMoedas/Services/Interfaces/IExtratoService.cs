using SistemaMoedas.Classes;

namespace SistemaMoedas.Services.Interfaces
{
    public interface IExtratoService
    {
        public IList<Transferencia> ListarPorProfessor(int codigo);
        public IList<Transferencia> ListarPorAluno(int codigo);
    }
}
