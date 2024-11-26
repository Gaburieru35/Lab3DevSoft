using Microsoft.AspNetCore.Mvc;
using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Model;
using SistemaMoedas.Services;
using SistemaMoedas.Services.Interfaces;

namespace SistemaMoedas.Controllers
{
    public class VantagemController : ControllerBase
    {

        public VantagemController(IRepositoryWork repositorio) : base(repositorio)
        { }

        public IActionResult Index()
        {
            VantagemService vantagemService = new VantagemService(Contexto);
            ListarVantagemModel vantagemModel = new ListarVantagemModel();

            vantagemModel.ListaVantagens = vantagemService.ListarTodos().ToList();

            return PartialView("~/Views/Partial/Vantagem/Vantagem.cshtml", vantagemModel);
        }

        public JsonResult Cadastrar(Vantagem vantagem, IFormFile imageFile)
        {

            VantagemService vantagemService = new VantagemService(Contexto);
            vantagem.TituloVantagem = vantagem.TituloVantagem;
            vantagem.DescricaoVantagem = vantagem.DescricaoVantagem;
            vantagem.ValorVantagem = vantagem.ValorVantagem;

            if (imageFile != null && imageFile.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    imageFile.CopyTo(memoryStream);
                    vantagem.FotoProduto = memoryStream.ToArray();
                }
            }

            vantagemService.Incluir(vantagem);

            return Json(new { teste = "Incluido" });
        }

        [HttpGet]
        public IActionResult ObterImagem(int id)
        {

            VantagemService vantagemService = new VantagemService(Contexto);
            var vantagem = vantagemService.ListarTodos().Where(x => x.CodigoVantagem == id).First();

            if (vantagem == null || vantagem.FotoProduto == null)
            {
                return NotFound();
            }

            return File(vantagem.FotoProduto, "image/jpeg");
        }

        public JsonResult Comprar(int id, int aluno)
        {
            VantagemService vantagemService = new VantagemService(Contexto);
            Vantagem vantagem = vantagemService.BuscarPorId(id);
            VantagemAlunoService vantagemAlunoService = new VantagemAlunoService(Contexto);

            AlunoService alunoService = new AlunoService(Contexto);
            Aluno alumni = alunoService.ListarPorCodigo(aluno);

            if (alumni.QuantidadeMoedasAluno >= vantagem.ValorVantagem)
            {
                alunoService.EnviarMoedas(alumni, vantagem.ValorVantagem);
                vantagemAlunoService.AtribuirVantagem(alumni, vantagem);


                return Json(new { sucesso = true });
            }
            else
            {
                return Json(new { sucesso = false });
            }
        }

        public List<Vantagem> ListarVantagens()
        {
            VantagemService vantagemService = new VantagemService(Contexto);
            return vantagemService.ListarTodos().ToList();
        }

        public IActionResult Inventario(int aluno)
        {
            VantagemAlunoService vantagemAlunoService = new VantagemAlunoService(Contexto);

            ListarVantagemModel vantagemModel = new ListarVantagemModel();

            vantagemModel.ListaVantagens = vantagemAlunoService.ListarVantagemPorAluno(aluno);

            return PartialView("~/Views/Partial/Vantagem/Inventario.cshtml", vantagemModel);
        }
    }
}
