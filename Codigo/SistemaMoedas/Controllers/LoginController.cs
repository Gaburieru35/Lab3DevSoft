using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Model;
using SistemaMoedas.Services;

namespace SistemaMoedas.Controllers
{
    public class LoginController : ControllerBase
    {
        public LoginController(IRepositoryWork repositorio) : base(repositorio)
        {
        }

        public IActionResult Index()
        {
            AlunoService alunoService = new AlunoService(Contexto);
            Aluno aluno = alunoService.listarPorEmail(HttpContext.Session.GetString("_emailAluno"));

            if (aluno != null)
            {
                return RedirectToAction("Index", "/DashBoard");
            }

            return View();
        }

        public JsonResult Logar(String email, String senha)
        {

            AlunoService alunoService = new AlunoService(Contexto);
            Aluno aluno = alunoService.logar(email, senha);


            if (aluno.CpfAluno != null)
            {
                Usuario usuario = new Usuario();
                usuario.IdUsuario = aluno.CodigoAluno;
                usuario.EmailUsuario = email;
                usuario.TipoUsuario = Constantes.Constantes.TiposUsuarios.Aluno;
                usuario.NomeUsuario = aluno.NomeAluno;

                ModelBase modelBase = new ModelBase(usuario);
                HttpContext.Session.SetString("_email", email);
                HttpContext.Session.SetString("_tipo", ((int)Constantes.Constantes.TiposUsuarios.Aluno).ToString());
                HttpContext.Session.SetString("_nome",usuario.NomeUsuario);
                HttpContext.Session.SetString("_idCliente", aluno.CodigoAluno.ToString());
            } else
            {
                throw new Exception();
            }

            return Json(new { aluno });
        }

        public JsonResult LogarParceiro(String email, String senha)
        {

            ParceiroService parceiroService = new ParceiroService(Contexto);
            Parceiro parceiro = parceiroService.logar(email, senha);


            if (parceiro.CnpjParceiro != null)
            {
                Usuario usuario = new Usuario();
                usuario.IdUsuario = parceiro.CodigoParceiro;
                usuario.EmailUsuario = email;
                usuario.TipoUsuario = Constantes.Constantes.TiposUsuarios.Parceiro;
                usuario.NomeUsuario = parceiro.NomeParceiro;

                ModelBase modelBase = new ModelBase(usuario);
                HttpContext.Session.SetString("_email", email);
                HttpContext.Session.SetString("_tipo", ((int)Constantes.Constantes.TiposUsuarios.Parceiro).ToString());
                HttpContext.Session.SetString("_nome", usuario.NomeUsuario);
                HttpContext.Session.SetString("_idCliente", parceiro.CodigoParceiro.ToString());
            }
            else
            {
                throw new Exception();
            }

            return Json(new { parceiro });
        }

        public JsonResult LogarProfessor(String email, String senha)
        {

            ProfessorService professorService = new ProfessorService(Contexto);
            Professor professor = professorService.logar(email, senha);


            if (professor.CpfProfessor != null)
            {
                Usuario usuario = new Usuario();
                usuario.IdUsuario = professor.CodigoProfessor;
                usuario.EmailUsuario = email;
                usuario.TipoUsuario = Constantes.Constantes.TiposUsuarios.Professor;
                usuario.NomeUsuario = professor.NomeProfessor;

                ModelBase modelBase = new ModelBase(usuario);
                HttpContext.Session.SetString("_email", email);
                HttpContext.Session.SetString("_tipo", ((int)Constantes.Constantes.TiposUsuarios.Professor).ToString());
                HttpContext.Session.SetString("_nome", usuario.NomeUsuario);
                HttpContext.Session.SetString("_idCliente", professor.CodigoProfessor.ToString());
            }
            else
            {
                throw new Exception();
            }

            return Json(new { professor });
        }

        public IActionResult Logout()
        {
            if (!String.IsNullOrEmpty(HttpContext.Session.GetString("_email")))
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Index", "/Login");
            }

            return RedirectToAction("Index", "/Dashboard");

        }
    }
}
