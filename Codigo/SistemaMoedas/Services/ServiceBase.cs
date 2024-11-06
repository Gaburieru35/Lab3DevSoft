using SistemaMoedas.IRepository;

namespace SistemaMoedas.Services
{
    public class ServiceBase
    {
        internal IRepositoryWork Contexto;
        public ServiceBase(IRepositoryWork contexto)
        {
            Contexto = contexto ?? throw new ArgumentNullException(nameof(contexto));
        }

        public void Salvar()
        {
            int contador = 1;
            while (contador > 0 && contador <= 1000)
            {
                try
                {
                    Contexto.SalvarAlteracoes();
                    contador = 0; //sai do loop
                }
                catch (Exception ex)
                {

                }
            }
        }
    }
}
