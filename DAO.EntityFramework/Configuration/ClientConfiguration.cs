using System.Data.Entity.ModelConfiguration;
using Entity;

namespace DAO.EntityFramework.Configuration
{
    internal class ClientConfiguration : EntityTypeConfiguration<Client>
    {
        internal ClientConfiguration()
        {
            this.ToTable("Client");

            this.HasKey(client => client.Id);
            this.Property(client => client.CUIL).HasMaxLength(255).HasColumnType("varchar").IsRequired();
            this.Property(client => client.Name).HasMaxLength(255).HasColumnType("varchar").IsRequired();

        }
    }
}
