using Microsoft.EntityFrameworkCore;
using GoopCadastroDeVeiculos.Models;

namespace GoopCadastroDeVeiculos.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Veiculo> Veiculos { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Veiculo>()
                .HasKey(v => v.Id);
        }
    }
}
