using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeSpaceAPI.Domain.Entities;

namespace SafeSpaceAPI.Infrastructure.Mappings
{
    public class SolicitacaoAjudaMapping : IEntityTypeConfiguration<SolicitacaoAjuda>
    {
        public void Configure(EntityTypeBuilder<SolicitacaoAjuda> builder)
        {
            builder.ToTable("SolicitacoesAjuda");

            builder.HasKey(s => s.Id);

            builder.Property(s => s.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder.Property(s => s.Descricao)
                .HasColumnName("DESCRICAO")
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(s => s.DataSolicitacao)
                .HasColumnName("DATA_SOLICITACAO")
                .IsRequired();

            builder.Property(s => s.IdUsuarioSS)
                .HasColumnName("ID_USUARIO_SS")
                .IsRequired();
        }
    }
}
