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

            base.OnModelCreating(modelBuilder);
        }

    }
}