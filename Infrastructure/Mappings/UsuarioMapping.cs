using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeSpaceAPI.Domain.Entities;

namespace SafeSpaceAPI.Infrastructure.Mappings
{
    public class UsuarioMapping : IEntityTypeConfiguration<UsuarioSS>
    {
        public void Configure(EntityTypeBuilder<UsuarioSS> builder)
        {
            builder.ToTable("UsuarioSS");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasColumnName("NOME")
                .HasMaxLength(100);

            builder.Property(u => u.Email)
                .IsRequired()
                .HasColumnName("EMAIL")
                .HasMaxLength(100);

            builder.Property(u => u.Telefone)
                .IsRequired()
                .HasColumnName("TELEFONE")
                .HasMaxLength(20);

            builder.Property(u => u.Senha)
                .IsRequired()
                .HasColumnName("SENHA")
                .HasMaxLength(255);

            builder.Property(u => u.TipoUsuario)
                .IsRequired()
                .HasColumnName("TIPO")
                .HasConversion<string>();

            builder.Property(u => u.DataCadastro)
                .IsRequired();
        }
    }
}
