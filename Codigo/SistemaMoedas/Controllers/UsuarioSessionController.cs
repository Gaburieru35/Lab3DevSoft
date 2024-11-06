using Microsoft.AspNetCore.Mvc;
using SistemaMoedas.Classes;
using SistemaMoedas.Services;

namespace SistemaMoedas.Controllers
{
    public class UsuarioSessionController
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UsuarioSessionController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public Usuario RetornarUsuarioSessao()
        {
            try
            {
                var httpContext = _httpContextAccessor?.HttpContext;
                if (httpContext == null)
                    return null;

                Constantes.Constantes.TiposUsuarios tipo = RetornarTipoUsuario();
                Usuario usuario = new Usuario
                {
                    IdUsuario = int.Parse(httpContext.Session.GetString("_idCliente")),
                    EmailUsuario = httpContext.Session.GetString("_email"),
                    TipoUsuario = tipo,
                    NomeUsuario = httpContext.Session.GetString("_nome")
                };

                return usuario;
            }
            catch (Exception)
            {
                // Possivelmente redirecionar para login
                return null;
            }
        }

        private Constantes.Constantes.TiposUsuarios RetornarTipoUsuario()
        {
            try
            {
                var httpContext = _httpContextAccessor?.HttpContext;
                if (httpContext == null)
                    return Constantes.Constantes.TiposUsuarios.Aluno;

                return (Constantes.Constantes.TiposUsuarios)int.Parse(httpContext.Session.GetString("_tipo"));
            }
            catch (Exception)
            {
                return Constantes.Constantes.TiposUsuarios.Aluno;
            }
        }
    }
}
