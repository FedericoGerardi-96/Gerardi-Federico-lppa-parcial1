using Parcial.Shared.Parcial.Entities.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Parcial.Domain.Parcial.Data.Services
{
    public class AfiliadoDbContext : DbContext
    {
       public DbSet<Afiliado> Product { get; set; }

        public AfiliadoDbContext() : base("DefaultConnection")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}