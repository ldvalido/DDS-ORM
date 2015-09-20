using System.Data.Entity.ModelConfiguration;
using Entity;

namespace DAO.EntityFramework.Configuration
{
    internal class SKUConfiguration : EntityTypeConfiguration<SKU>
    {
        internal SKUConfiguration()
        {
            this.ToTable("SKU");

            this.HasKey(sku => sku.Id);

            this.Property(sku=>sku.Name);

            this.Property(sku=>sku.Price);
        }
    }
}
