using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;

namespace SistemaMoedas.Model
{
    public class ModelBase
    {

        private Classes.Usuario usuarioLogado;

        public ModelBase(Classes.Usuario UsuarioLogado)
        {
            usuarioLogado = UsuarioLogado;
        }

        public Classes.Usuario UsuarioLogado
        {
            get
            {
                return usuarioLogado;
            }
        }

    }
}
