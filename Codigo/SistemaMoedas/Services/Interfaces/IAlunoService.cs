using SistemaMoedas.Classes;

namespace SistemaMoedas.Services.Interfaces
{
    public interface IAlunoService
    {
        public void incluir(Aluno aluno);
        public Aluno logar(String email, String senha);
        public Aluno listarPorEmail(String email);
    }
}
