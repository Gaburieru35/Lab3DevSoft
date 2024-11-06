using SistemaMoedas.Classes;

namespace SistemaMoedas.Services.Interfaces
{
    public interface IParceiroService
    {
        public void incluir(Parceiro parceiro);
        public Parceiro logar(String email, String senha);
        public Parceiro listarPorEmail(String email);
    }
}
