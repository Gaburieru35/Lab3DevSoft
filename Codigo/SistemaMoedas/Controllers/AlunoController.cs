using Microsoft.AspNetCore.Mvc;
using SistemaMoedas.IRepository;
using SistemaMoedas.Model;
using SistemaMoedas.Services;

namespace SistemaMoedas.Controllers
{
    public class AlunoController : ControllerBase
    {
        public AlunoController(IRepositoryWork repositorio) : base(repositorio)
        {
        }

        public IActionResult Index()
        {
            AlunoService alunoService = new AlunoService(Contexto);
            ListaAlunoModel objModel = new ListaAlunoModel();

            objModel.ListaAlunos = alunoService.ListarTodos();

            return View(objModel);
        }
    }
}
