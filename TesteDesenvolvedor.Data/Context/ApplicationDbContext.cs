using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using TesteDesenvolvedor.Domain.Entities;

namespace TesteDesenvolvedor.Infra.Ioc.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<ProcessoSeletivo> ProcessoSeletivos { get; set; }
        public DbSet<Lead> Leads { get; set; }
        public DbSet<Oferta> Ofertas { get; set; }
        public DbSet<Inscricao> Inscricoes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ProcessoSeletivo>()
            .HasKey(p => p.Id);

            builder.Entity<Lead>()
            .HasKey(l => l.Id);

            builder.Entity<Oferta>()
            .HasKey(o => o.Id);

            builder.Entity<Inscricao>()
                .HasKey(i => i.Id);

            builder.Entity<Inscricao>()
                .HasOne(i => i.Lead)
                .WithMany(l => l.Inscricoes)
                .HasForeignKey(i => i.LeadId);

            builder.Entity<Inscricao>()
                .HasOne(i => i.ProcessoSeletivo)
                .WithMany(p => p.Inscricoes)
                .HasForeignKey(i => i.ProcessoSeletivoId);

            builder.Entity<Inscricao>()
                .HasOne(i => i.Oferta)
                .WithMany(o => o.Inscricoes)
                .HasForeignKey(i => i.OfertaId);
        }
    }
}
