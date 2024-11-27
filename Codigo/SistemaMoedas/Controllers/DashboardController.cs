using Microsoft.AspNetCore.Mvc;
using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Model;
using SistemaMoedas.Services;

namespace SistemaMoedas.Controllers
{
    public class DashboardController : ControllerBase
    {
        public DashboardController(IRepositoryWork repositorio) : base(repositorio)
        {
        }

        public IActionResult Index()
        {
            AlunoService alunoService = new AlunoService(Contexto);
            ProfessorService professorService = new ProfessorService(Contexto);
            InstituicaoService instituicaoService = new InstituicaoService(Contexto);
            CursoService cursoService = new CursoService(Contexto);

            UsuarioLogadoModel objModel = new UsuarioLogadoModel();

            objModel.Aluno = alunoService.listarPorEmail(HttpContext.Session.GetString("_email"));
            objModel.Professor = professorService.listarPorEmail(HttpContext.Session.GetString("_email"));

            Usuario usuario = new Usuario();

            int tipo = int.Parse(HttpContext.Session.GetString("_tipo"));

            usuario.TipoUsuario = (Constantes.Constantes.TiposUsuarios)tipo;
            usuario.EmailUsuario = HttpContext.Session.GetString("_email");
            usuario.NomeUsuario = HttpContext.Session.GetString("_nome");

            switch ((int)usuario.TipoUsuario)
            {
                case 1:
                    objModel.Instituicao = instituicaoService.ListarPorCodigo(objModel.Aluno.InstituicaoAluno);
                    objModel.Curso = cursoService.ListarPorCodigo(objModel.Aluno.CursoAluno);

                    break;

                case 2:
                    objModel.Instituicao = instituicaoService.ListarPorCodigo(objModel.Professor.InstituicaoProfessor);

                    break;
            }

            objModel.TiposUsuario = (Constantes.Constantes.TiposUsuarios)tipo;

            objModel.Usuario = usuario;

            return View(objModel);
        }
    }
}
