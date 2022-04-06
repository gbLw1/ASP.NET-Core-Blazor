using DigitalCursos.Models.Models;
using Microsoft.EntityFrameworkCore;

namespace DigitalCursos.Api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(assembly: GetType().Assembly);

            #region [SEEDWORK]

            //modelBuilder.Entity<Curso>().HasData(Enumerable.Range(1, 100).Select(c => new Curso
            //{
            //    CursoId = c,
            //    CursoNome = $"Curso {c}",
            //    Descricao = $"Descrição do curso {c}",
            //    CargaHoraria = c,
            //    Inicio = new DateTime(2020, 07, 01),
            //    Preco = 150.00M,
            //    Logo = null
            //}));

            #endregion
        }
    }
}
