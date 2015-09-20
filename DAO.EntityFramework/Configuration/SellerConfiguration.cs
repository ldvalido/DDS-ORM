using System.Data.Entity.ModelConfiguration;
using Entity;

namespace DAO.EntityFramework.Configuration
{
    internal class SellerConfiguration : EntityTypeConfiguration<Seller>
    {
        internal SellerConfiguration()
        {
            this.ToTable("Seller");
        }
    }
}
