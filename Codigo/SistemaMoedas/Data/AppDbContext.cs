using Microsoft.EntityFrameworkCore;
using SistemaMoedas.Classes;

namespace SistemaMoedas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Parceiro> Parceiro { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Transferencia> Transferencias { get; set; }
    }
}
