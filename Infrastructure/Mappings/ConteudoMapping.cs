using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeSpaceAPI.Domain.Entities;

namespace SafeSpaceAPI.Infrastructure.Mappings
{
    public class ConteudoMapping : IEntityTypeConfiguration<ConteudoAutoAjuda>
    {
        public void Configure(EntityTypeBuilder<ConteudoAutoAjuda> builder)
        {
            builder.ToTable("ConteudoAutoAjuda");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder.Property(c => c.Titulo)
                .HasColumnName("TITULO")
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(c => c.URL)
                .HasColumnName("URL")
                .IsRequired()
                .HasMaxLength(500);

            builder.Property(c => c.Descricao)
                .HasColumnName("DESCRICAO")
                .IsRequired()
                .HasMaxLength(1000);

            builder.Property(c => c.DataPublicacao)
                .HasColumnName("DATA_PUBLICACAO")
                .IsRequired();

            builder.Property(c => c.TipoConteudo)
                .HasColumnName("TIPO_CONTEUDO")
                .IsRequired()
                .HasConversion<string>();
        }
    }
}
