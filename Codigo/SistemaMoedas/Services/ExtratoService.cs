using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Services.Interfaces;

namespace SistemaMoedas.Services
{
    public class ExtratoService : ServiceBase, IExtratoService
    {
        public ExtratoService(IRepositoryWork contexto) : base(contexto)
        {
        }

        public IList<Transferencia> ListarPorAluno(int codigo)
        {
            AlunoService alunoService = new AlunoService(Contexto);
            Aluno aluno = alunoService.ListarPorCodigo(codigo);

            TransferenciaService transferenciaService = new TransferenciaService(Contexto);
            IList<Transferencia> transferencias = transferenciaService.TransferenciasPorAluno(codigo);

            return transferencias;
        }

        public IList<Transferencia> ListarPorProfessor(int codigo)
        {
            throw new NotImplementedException();
        }
    }
}
