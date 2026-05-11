using Microsoft.EntityFrameworkCore;
using ParkSolutions.Models;

namespace ParkSolutions.Data
{
    public class ParkContext : DbContext
    {
        public ParkContext(DbContextOptions<ParkContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }
        public DbSet<Vaga> Vagas { get; set; }
        public DbSet<Movimentacao> Movimentacoes { get; set; }
        public DbSet<Configuracao> Configuracoes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movimentacao>()
                .Property(m => m.ValorCobrado)
                .HasPrecision(10, 2);
        }
    }
}