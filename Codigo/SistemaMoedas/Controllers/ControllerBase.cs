using SistemaMoedas.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace SistemaMoedas.Controllers
{
    public class ControllerBase : Controller
    {
        protected readonly IRepositoryWork Contexto;

        public ControllerBase(IRepositoryWork repositorio)
        {
            Contexto = repositorio ?? throw new ArgumentNullException(nameof(repositorio));
        }
    }
}
