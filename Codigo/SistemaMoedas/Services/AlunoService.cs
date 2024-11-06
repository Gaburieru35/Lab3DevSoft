using Microsoft.AspNetCore.Mvc;
using SistemaMoedas.Classes;
using SistemaMoedas.IRepository;
using SistemaMoedas.Services.Interfaces;

namespace SistemaMoedas.Services
{
    public class AlunoService : ServiceBase, IAlunoService
    {
        public AlunoService(IRepositoryWork contexto) : base(contexto)
        {
        }

        public void incluir(Aluno aluno)
        {
            Aluno alunoDuplicado = Contexto.AlunoRepository.RetornarFiltro(
                a => a.CpfAluno == aluno.CpfAluno ||
                a.EmailAluno == aluno.EmailAluno).FirstOrDefault();

            Contexto.AlunoRepository.Incluir(aluno);
            Salvar();
        }

        public Aluno listarPorEmail(string email)
        {
            Aluno aluno = Contexto.AlunoRepository.RetornarFiltro(a => a.EmailAluno == email).FirstOrDefault();
            return aluno;
        }

        public Aluno logar(string email, string senha)
        {
            Aluno aluno = Contexto.AlunoRepository.RetornarFiltro(a => a.EmailAluno == email && a.SenhaAluno == senha).FirstOrDefault();
            if(aluno == null) { return new Aluno(); }
            return aluno;
        }

        public IList<Aluno> ListarTodos()
        {
            IList<Aluno> alunos = Contexto.AlunoRepository.ListarTodos().ToList();
            return alunos;
        }

        public Aluno ListarPorCodigo(int codigo)
        {
            Aluno aluno = Contexto.AlunoRepository.ListarPorCodigo(codigo);
            return aluno;
        }

        public void ReceberMoedas(Aluno aluno, int quantidadeRecebida)
        {
            aluno.QuantidadeMoedasAluno += quantidadeRecebida;
            Contexto.AlunoRepository.Alterar(aluno, a => a.CodigoAluno);
            Salvar();
        }
    }
}
