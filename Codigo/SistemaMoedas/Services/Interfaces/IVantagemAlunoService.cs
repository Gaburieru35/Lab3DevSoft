using SistemaMoedas.Classes;

namespace SistemaMoedas.Services.Interfaces
{
    public interface IVantagemAlunoService
    {
        public void AtribuirVantagem(Aluno aluno, Vantagem vantagem);

        public IList<Vantagem> ListarTodos();
    }
}
