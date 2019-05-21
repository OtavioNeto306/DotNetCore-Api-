
using Ammamentar.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ammamentar.Repository
{

    public class AmmamentarContext : DbContext
    {

        public AmmamentarContext(DbContextOptions<AmmamentarContext> options) : base (options){}

        public DbSet <Pessoa> Pessoas   { get; set; } // Pega a Model Eventos e seus Atributos
        public DbSet <Endereco> Enderecos   { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

    }
}