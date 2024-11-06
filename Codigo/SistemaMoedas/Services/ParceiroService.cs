using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Services.Interfaces;

namespace SistemaMoedas.Services
{
    public class ParceiroService : ServiceBase, IParceiroService
    {
        public ParceiroService(IRepositoryWork contexto) : base(contexto)
        {
        }

        public void incluir(Parceiro parceiro)
        {
            Parceiro parceiroDuplicado = Contexto.ParceiroRepository.RetornarFiltro(
               a => a.CnpjParceiro == parceiro.CnpjParceiro ||
               a.EmailParceiro == parceiro.EmailParceiro).FirstOrDefault();

            Contexto.ParceiroRepository.Incluir(parceiro);
            Salvar();
        }

        public Parceiro listarPorEmail(string email)
        {
            Parceiro parceiro = Contexto.ParceiroRepository.RetornarFiltro(a => a.EmailParceiro == email).FirstOrDefault();
            return parceiro;
        }

        public Parceiro logar(string email, string senha)
        {
            Parceiro parceiro = Contexto.ParceiroRepository.RetornarFiltro(a => a.EmailParceiro == email && a.SenhaParceiro == senha).FirstOrDefault();
            if (parceiro == null) { return new Parceiro(); }
            return parceiro;
        }
    }
}
