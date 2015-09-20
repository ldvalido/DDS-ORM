using System.Data.Entity.ModelConfiguration;
using Entity;

namespace DAO.EntityFramework.Configuration
{
    internal class BillingConfiguration : EntityTypeConfiguration<Billing>
    {
        internal BillingConfiguration()
        {
            this.ToTable("Billing");
        }
    }
}
