using DigitalCursos.Models.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DigitalCursos.Api.EntityTypeConfigurations
{
    public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder
                .Property(p => p.Nome)
                .HasMaxLength(150);

            builder
                .Property(p => p.SobreNome)
                .HasMaxLength(100);

            builder
                .Property(p => p.Email)
                .HasMaxLength(100);
        }
    }
}
