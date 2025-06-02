using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeSpaceAPI.Domain.Entities;

namespace SafeSpaceAPI.Infrastructure.Mappings
{
    public class AgendamentoMapping : IEntityTypeConfiguration<Agendamento>
    {
        public void Configure(EntityTypeBuilder<Agendamento> builder)
        {
            builder.ToTable("Agendamento");

            builder.HasKey(a => a.Id);

            builder.Property(a => a.DataAgendamento)
                .IsRequired()
                .HasColumnName("DATA_AGENDAMENTO");

            builder.Property(a => a.Descricao)
                .IsRequired()
                .HasColumnName("DESCRICAO")
                .HasMaxLength(500);

            // Configura FK e relacionamento 1:N
            builder.HasOne(a => a.UsuarioSS)
                   .WithMany(u => u.Agendamentos)
                   .HasForeignKey(a => a.UsuarioSSId)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.Cascade); // opcional, depende da sua regra
        }

    }
}
