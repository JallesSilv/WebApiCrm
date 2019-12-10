using Microsoft.EntityFrameworkCore;
using WebApiCrm.Models.Auxiliar;
using WebApiCrm.Models.Entidades;

namespace WebApiCrm.Models.DAO
{
    public class ProductDbContext:DbContext
    {
        public ProductDbContext() : base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(FactoryConnection.connection);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
                
        public DbSet<Cliente> Cliente { get; set; }

    }
}
