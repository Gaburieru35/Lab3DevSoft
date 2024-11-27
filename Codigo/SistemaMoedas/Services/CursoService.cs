using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Services.Interfaces;

namespace SistemaMoedas.Services
{
    public class CursoService : ServiceBase, ICursoService
    {
        public CursoService(IRepositoryWork contexto) : base(contexto)
        {
        }

        public IList<Curso> listar()
        {
            IList<Curso> cursos = Contexto.CursoRepository.ListarTodos().ToList();

            return cursos;
        }

        public Curso ListarPorCodigo(int codigo)
        {
            Curso cur = Contexto.CursoRepository.ListarPorCodigo(codigo);
            return cur;
        }
    }
}
