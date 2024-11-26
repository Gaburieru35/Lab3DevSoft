using Microsoft.EntityFrameworkCore;
using SistemaMoedas.Classes;

namespace SistemaMoedas.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Transferencia>()
                .HasOne(t => t.OrigemTransferencia)
                .WithMany()
                .HasForeignKey(t => t.OrigemTransferenciaCodigoProfessor);

            modelBuilder.Entity<Transferencia>()
                .HasOne(t => t.DestinoTransferencia)
                .WithMany()
                .HasForeignKey(t => t.DestinoTransferenciaCodigoAluno);
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Instituicao> Instituicoes { get; set; }
        public DbSet<Professor> Professor { get; set; }
        public DbSet<Parceiro> Parceiro { get; set; }
        public DbSet<Curso> Curso { get; set; }
        public DbSet<Transferencia> Transferencias { get; set; }

        public DbSet<Vantagem> Vantagens { get; set; }

        public DbSet<VantagemAluno> VantagemAlunos { get; set; }
    }
}
