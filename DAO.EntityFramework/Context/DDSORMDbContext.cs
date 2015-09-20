using System.Data.Entity;
using DAO.EntityFramework.Configuration;
using Entity;

namespace DAO.EntityFramework.Context
{
    public class DDSORMDbContext : DbContext
    {
        public DDSORMDbContext() : base("DDORMCnnStr")
        {
            Database.SetInitializer(new MySqlInitializer<DropCreateDatabaseAlways<DDSORMDbContext> ());
            //Database.SetInitializer(new DropCreateDatabaseAlways<DDSORMDbContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new BillingConfiguration());
            modelBuilder.Configurations.Add(new ClientConfiguration());
            modelBuilder.Configurations.Add(new SellerConfiguration());
            modelBuilder.Configurations.Add(new SKUConfiguration());
            
        }

        #region Tables
        public DbSet<Client> Clients { get; set; } 
        public DbSet<SKU> SKUs { get; set; } 
        #endregion
    }
}
