using Microsoft.AspNetCore.Mvc;
using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Services;

namespace SistemaMoedas.Controllers
{
    public class CadastroParceiroController : ControllerBase
    {
        public CadastroParceiroController(IRepositoryWork repositorio) : base(repositorio)
        {
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Cadastrar(Parceiro parceiro)
        {
            ParceiroService parceiroService = new ParceiroService(Contexto);
            parceiro.DataCadastroParceiro = DateTime.Now;
            try
            {
                parceiroService.incluir(parceiro);
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    mensagem = "Erro ao Incluir parceiro.",
                });
                throw;
            }

            return Json(new { parceiro });
        }
    }
}
