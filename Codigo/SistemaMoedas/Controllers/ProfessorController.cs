using Microsoft.AspNetCore.Mvc;
using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Repository;
using SistemaMoedas.Services;

namespace SistemaMoedas.Controllers
{
    public class ProfessorController : ControllerBase
    {
        public ProfessorController(IRepositoryWork repositorio) : base(repositorio)
        { }
        public IActionResult Index()
        {

            return View();
        }

        public JsonResult TransferirMoedas(int codigoPara, int quantidade)
        {

            AlunoService alunoService = new AlunoService(Contexto);
            Aluno aluno = alunoService.ListarPorCodigo(codigoPara);

            ProfessorService professorService = new ProfessorService(Contexto);
            TransferenciaService transferenciaService = new TransferenciaService(Contexto);

            Professor professor = professorService.listarPorEmail(HttpContext.Session.GetString("_email"));
            Transferencia transferencia = new Transferencia();
            transferencia.OrigemTransferencia = professor.CodigoProfessor;
            transferencia.DestinoTransferencia = aluno.CodigoAluno;
            transferencia.DataHoraTransferencia = DateTime.Now;
            transferencia.ValorTransferencia = quantidade;
            transferencia.TipoTransferencia = 0;

            try
            {
                if(professor.MoedasProfessor - quantidade < 0)
                {
                    throw new Exception();
                }
                else
                {
                    professorService.TransferirMoedas(professor, quantidade);
                    alunoService.ReceberMoedas(aluno, quantidade);

                    transferenciaService.incluir(transferencia);


                }
            } catch (Exception ex) { }

            return Json
                (new { codigoPara, quantidade });
        }
    }
}
