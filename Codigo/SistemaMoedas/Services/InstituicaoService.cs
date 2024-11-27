using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Services.Interfaces;

namespace SistemaMoedas.Services
{
    public class InstituicaoService : ServiceBase, IInstituicaoService
    {
        public InstituicaoService(IRepositoryWork contexto) : base(contexto)
        {
        }
        public IList<Instituicao> listar()
        {
            IList<Instituicao> listaInstituicao = Contexto.InstituicaoRepository.ListarTodos().ToList();
            return listaInstituicao;

        }

        public Instituicao ListarPorCodigo(int codigo)
        {
            Instituicao ints = Contexto.InstituicaoRepository.ListarPorCodigo(codigo);
            return ints;
        }
    }
}
