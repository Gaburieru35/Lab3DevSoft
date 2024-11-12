using SistemaMoedas.Classes;

namespace SistemaMoedas.IRepository
{
    public interface IRepositoryWork
    {
        void SalvarAlteracoes();
        IRepository<Aluno> AlunoRepository { get; }
        IRepository<Instituicao> InstituicaoRepository { get; }
        IRepository<Curso> CursoRepository { get; }
        IRepository<Parceiro> ParceiroRepository { get; }
        IRepository<Professor> ProfessorRepository { get; }
        IRepository<Transferencia> TransferenciaRepository { get; }
        IRepository<Vantagem> VantagemRepository { get; }
    }
}
