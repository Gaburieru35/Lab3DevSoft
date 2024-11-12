using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Services.Interfaces;

namespace SistemaMoedas.Services
{
    public class VantagemService : ServiceBase, IVantagemService
    {
        public VantagemService(IRepositoryWork contexto) : base(contexto) 
        {
        }
        public void Incluir(Vantagem vantagem)
        {
            Contexto.VantagemRepository.Incluir(vantagem);
            Salvar();
        }

        public IList<Vantagem> ListarTodos()
        {
            IList<Vantagem> vantagens = Contexto.VantagemRepository.ListarTodos().ToList();
            return vantagens;
        }
    }
}
