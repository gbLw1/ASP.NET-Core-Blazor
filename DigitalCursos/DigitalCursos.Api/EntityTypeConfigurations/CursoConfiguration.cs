using DigitalCursos.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalCursos.Api.EntityTypeConfigurations
{
    public class CursoConfiguration : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
            builder
                .HasKey(c => c.CursoId);

            builder
                .Property(p => p.CursoNome)
                .HasMaxLength(150);

            builder
                .Property(p => p.Descricao)
                .HasMaxLength(250);

            builder
                .Property(p => p.Preco)
                .HasColumnType("decimal(18,2)");
        }
    }
}
