using Microsoft.EntityFrameworkCore;
using SafeSpaceAPI.Domain.Entities;
using SafeSpaceAPI.Infrastructure.Mappings;

namespace SafeSpaceAPI.Infrastructure.Context
{
    public class SafeSpaceContext : DbContext
    {
        public SafeSpaceContext(DbContextOptions<SafeSpaceContext> options)
            : base(options)
        {
        }

        public DbSet<UsuarioSS> Usuarios { get; set; }

        public DbSet<SafeSpaceAPI.Domain.Entities.SolicitacaoAjuda> SolicitacaoAjuda { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfiguration(new SolicitacaoAjudaMapping());
            modelBuilder.ApplyConfiguration(new ConteudoMapping());
            modelBuilder.ApplyConfiguration(new AgendamentoMapping());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<SafeSpaceAPI.Domain.Entities.ConteudoAutoAjuda> ConteudoAutoAjuda { get; set; } = default!;
        public DbSet<SafeSpaceAPI.Domain.Entities.Agendamento> Agendamento { get; set; } = default!;

    }
}