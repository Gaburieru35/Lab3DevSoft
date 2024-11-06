using Microsoft.AspNetCore.Mvc;
using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Model;
using SistemaMoedas.Services;

namespace SistemaMoedas.Controllers
{
    public class ExtratoController : ControllerBase
    {
        public ExtratoController(IRepositoryWork repositorio) : base(repositorio)
        {
        }

        public IActionResult Index()
        {

            ListagemExtratoModel objModel = new ListagemExtratoModel();
            Constantes.Constantes.TiposUsuarios tipo = (Constantes.Constantes.TiposUsuarios)(int.Parse(HttpContext.Session.GetString("_tipo")));
            int codigo = int.Parse(HttpContext.Session.GetString("_idCliente"));

            switch (tipo)
            {
                case Constantes.Constantes.TiposUsuarios.Aluno:

                    objModel.Transferencias = TransferenciaPorAluno(codigo);

                    break;
                case Constantes.Constantes.TiposUsuarios.Professor:
                    objModel.Transferencias = TransferenciaPorProfessor(codigo);
                    
                    break;
                case Constantes.Constantes.TiposUsuarios.Parceiro:
                    break;
                default:
                    break;
            }

            objModel.IdUsuario = codigo;
            objModel.TiposUsuarios = tipo;

            return View(objModel);
        }

        public List<Transferencia> TransferenciaPorAluno(int codigo)
        {
            ListagemExtratoModel objModel = new ListagemExtratoModel();
            TransferenciaService transferenciaService = new TransferenciaService(Contexto);

            return transferenciaService.TransferenciasPorAluno(codigo).ToList();
        }

        public List<Transferencia> TransferenciaPorProfessor(int codigo)
        {
            ListagemExtratoModel objModel = new ListagemExtratoModel();
            TransferenciaService transferenciaService = new TransferenciaService(Contexto);

            return transferenciaService.TransferenciasPorProfessor(codigo).ToList();
        }
    }
}
