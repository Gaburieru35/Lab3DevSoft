using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Services.Interfaces;

namespace SistemaMoedas.Services
{
    public class TransferenciaService : ServiceBase, ITransferenciaService
    {
        public TransferenciaService(IRepositoryWork contexto) : base(contexto)
        {
        }

        public void incluir(Transferencia transferencia)
        {
            Contexto.TransferenciaRepository.Incluir(transferencia);
            Salvar();
        }

        public IList<Transferencia> Transferencias()
        {
            IList<Transferencia> transferencias = Contexto.TransferenciaRepository.ListarTodos().ToList();
            return transferencias;
        }

        public IList<Transferencia> TransferenciasPorAluno(int codigo)
        {
            IList<Transferencia> transferencias = Contexto.TransferenciaRepository.RetornarFiltro(t => t.DestinoTransferencia == codigo).ToList();
            return transferencias;
        }

        public IList<Transferencia> TransferenciasPorProfessor(int codigo)
        {
            IList<Transferencia> transferencias = Contexto.TransferenciaRepository.RetornarFiltro(t => t.OrigemTransferencia == codigo).ToList();
            return transferencias;
        }
    }
}
