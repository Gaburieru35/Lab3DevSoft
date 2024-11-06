using Microsoft.AspNetCore.Mvc;
using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Model;
using SistemaMoedas.Services;

namespace SistemaMoedas.Controllers
{
    public class CadastroController : ControllerBase
    {
        public CadastroController(IRepositoryWork repositorio) : base(repositorio)
        {
        }

        public IActionResult Index()
        {
            AlunoService alunoService = new AlunoService(Contexto);
            InstituicaoService instituicaoService = new InstituicaoService(Contexto);
            CursoService cursoService = new CursoService(Contexto);
            Aluno aluno = alunoService.listarPorEmail(HttpContext.Session.GetString("_email"));

            ListasLoginModel objModel = new ListasLoginModel();

            objModel.Instituicoes = instituicaoService.listar();
            objModel.Cursos = cursoService.listar();

            if (aluno != null)
            {
                return RedirectToAction("Index", "/DashBoard");
            }

            return View(objModel);
        }

        public IActionResult Cadastrar(Aluno aluno)
        {
            AlunoService alunoServico = new AlunoService(Contexto);
            aluno.DataCadastroAluno = DateTime.Now;
            aluno.QuantidadeMoedasAluno = 0;
            try
            {
                alunoServico.incluir(aluno);
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    mensagem = "Erro ao Incluir aluno.",
                });
                throw;
            }

            return RedirectToAction("Index", "/Login");
        }
    }
}
