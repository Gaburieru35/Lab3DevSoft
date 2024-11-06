using SistemaMoedas.Classes;

namespace SistemaMoedas.Services.Interfaces
{
    public interface IProfessorService
    {
        public void incluir(Professor aluno);
        public Professor logar(String email, String senha);
        public Professor listarPorEmail(String email);
    }
}
