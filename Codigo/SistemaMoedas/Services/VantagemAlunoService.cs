using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Services.Interfaces;

namespace SistemaMoedas.Services
{
    public class VantagemAlunoService : ServiceBase, IVantagemAlunoService
    {
        public VantagemAlunoService(IRepositoryWork contexto) : base(contexto)
        {
        }

        public void AtribuirVantagem(Aluno aluno, Vantagem vantagem)
        {
            VantagemAluno vantagemAluno = new VantagemAluno();
            vantagemAluno.CodigoAluno = aluno.CodigoAluno;
            vantagemAluno.CodigoVantagem = vantagem.CodigoVantagem;

            Contexto.VantagemAlunoRepository.Incluir(vantagemAluno);
            Salvar();
        }

        public IList<Vantagem> ListarTodos()
        {
            throw new NotImplementedException();
        }

        public List<Vantagem> ListarVantagemPorAluno(int codigoAluno)
        {
            List<VantagemAluno> vantagemAlunos = Contexto.VantagemAlunoRepository.ListarTodos().Where(x => x.CodigoAluno == codigoAluno).ToList();
            List<Vantagem> vantagens = new List<Vantagem>();
            vantagens = vantagemAlunos.Select(x => Contexto.VantagemRepository.ListarPorCodigo(x.CodigoVantagem)).ToList();
            return vantagens;
        }
    }
}
