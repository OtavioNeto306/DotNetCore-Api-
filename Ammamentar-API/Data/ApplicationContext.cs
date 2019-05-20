using Ammamentar.API.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Ammamentar.API.Data
{

    public class ApplicationContext : DbContext
    {
        private EntityTypeBuilder<Pessoa> entityTypeBuilder;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base (options){}

        public ApplicationContext(EntityTypeBuilder<Pessoa> entityTypeBuilder)
        {
            this.entityTypeBuilder = entityTypeBuilder;
        }

        public DbSet <Pessoa> Pessoas   { get; set; } // Pega a Model Eventos e seus Atributos

         protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            new ApplicationContext(model.Entity<Pessoa>());
        }

    }
}