using ListaDeProdutos.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaDeProdutos.DataContext
{
    public class AplicationContext : DbContext
    {
        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options)
        {

        }
        public DbSet<ProdutoModel> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProdutoModel>()
                .Property(p => p.Valor)
                .HasColumnType("decimal(18, 2)");
        }
    }
}

