using Microsoft.EntityFrameworkCore;
using SistemaMoedas.Classes;
using SistemaMoedas.Data;
using SistemaMoedas.IRepository;

namespace SistemaMoedas.Repository
{
    public class RepositoryWork : IRepositoryWork
    {
        private AppDbContext _context;
        private IRepository<Aluno> _alunoRepository;
        private IRepository<Instituicao> _instituicaoRepository;
        private IRepository<Curso> _cursoRepository;
        private IRepository<Parceiro> _parceiroRepository;
        private IRepository<Professor> _professorRepository;
        private IRepository<Transferencia> _transferenciaRepository;
        private IRepository<Vantagem> _vantagemRepository;
        public RepositoryWork(DbContextOptions<AppDbContext> context)
        {
            _context = new AppDbContext(context);
        }

        public void SalvarAlteracoes()
        {
            _context.SaveChanges();
        }

        public void Descartar()
        {
            _context.Dispose();
        }

        public IRepository<Aluno> AlunoRepository
        {
            get { return _alunoRepository ?? (_alunoRepository = new Repository<Aluno>(_context)); }
        }
        public IRepository<Instituicao> InstituicaoRepository
        {
            get { return _instituicaoRepository ?? (_instituicaoRepository = new Repository<Instituicao>(_context)); }
        }
        public IRepository<Curso> CursoRepository
        {
            get { return _cursoRepository ?? (_cursoRepository = new Repository<Curso>(_context)); }
        }
        public IRepository<Parceiro> ParceiroRepository
        {
            get { return _parceiroRepository ?? (_parceiroRepository = new Repository<Parceiro>(_context)); }
        }
        public IRepository<Professor> ProfessorRepository
        {
            get { return _professorRepository ?? (_professorRepository = new Repository<Professor>(_context)); }
        }
        public IRepository<Transferencia> TransferenciaRepository
        {
            get { return _transferenciaRepository ?? (_transferenciaRepository = new Repository<Transferencia>(_context)); }
        }
        public IRepository<Vantagem> VantagemRepository
        {
            get { return _vantagemRepository ?? (_vantagemRepository = new Repository<Vantagem>(_context)); }
        }
    }
}
