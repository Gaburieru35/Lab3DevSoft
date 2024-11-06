using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Services.Interfaces;

namespace SistemaMoedas.Services
{
    public class ProfessorService : ServiceBase, IProfessorService
    {
        public ProfessorService(IRepositoryWork contexto) : base(contexto)
        {
        }

        public void incluir(Professor professor)
        {
            Professor professorDuplicado = Contexto.ProfessorRepository.RetornarFiltro(
                 a => a.CpfProfessor == professor.CpfProfessor ||
                 a.EmailProfessor == professor.EmailProfessor).FirstOrDefault();

            Contexto.ProfessorRepository.Incluir(professor);
            Salvar();
        }

        public Professor listarPorEmail(string email)
        {
            Professor professor = Contexto.ProfessorRepository.RetornarFiltro(a => a.EmailProfessor == email).FirstOrDefault();
            return professor;
        }

        public Professor logar(string email, string senha)
        {
            Professor professor = Contexto.ProfessorRepository.RetornarFiltro(a => a.EmailProfessor == email && a.SenhaProfessor == senha).FirstOrDefault();
            if (professor == null) { return new Professor(); }
            return professor;
        }

        public void TransferirMoedas(Professor professor, int quantidade)
        {
            professor.MoedasProfessor -= quantidade;
            Salvar();
        }
    }
}
