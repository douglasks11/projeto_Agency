using projeto_agency.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace projeto_agency.DAL
{
    public class EFContext : DbContext
    {
        
        public EFContext() : base("EFConnectionString") {        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Properties<string>().Configure(p=> p.HasColumnType("varchar"));
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);

            
        }
        public DbSet<Autor> autor { get; set; }
        public DbSet<Livro> livro { get; set; }
    }
}