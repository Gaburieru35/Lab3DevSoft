using Microsoft.EntityFrameworkCore;
using SistemaMoedas.Classes;
using SistemaMoedas.Interfaces;
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
            IList<Transferencia> transferencias = Contexto.TransferenciaRepository.RetornarFiltro(t => t.DestinoTransferencia.CodigoAluno == codigo)
                                                                                  .Include(t => t.OrigemTransferencia) // Inclui a propriedade de navegação OrigemTransferencia
                                                                                  .Include(t => t.DestinoTransferencia)
                                                                                  .ToList();

            return transferencias;
        }

        public IList<Transferencia> TransferenciasPorProfessor(int codigo)
        {
            IList<Transferencia> transferencias = Contexto.TransferenciaRepository.RetornarFiltro(t => t.OrigemTransferencia.CodigoProfessor == codigo)
                                                                                  .Include(t => t.OrigemTransferencia) // Inclui a propriedade de navegação OrigemTransferencia
                                                                                  .Include(t => t.DestinoTransferencia)
                                                                                  .ToList();
            return transferencias;
        }
    }
}
