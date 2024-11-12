using Microsoft.AspNetCore.Mvc;
using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Model;
using SistemaMoedas.Services;

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

        public JsonResult Cadastrar(String titulo, String descricao, int valor)
        {

            VantagemService vantagemService = new VantagemService(Contexto);
            Vantagem vantagem = new Vantagem();
            vantagem.TituloVantagem = titulo;
            vantagem.DescricaoVantagem = descricao;
            vantagem.ValorVantagem = valor;

            vantagemService.Incluir(vantagem);

            return Json(new { titulo, descricao, valor });
        }
    }
}
