using System.Data.Entity;
using DAO.EntityFramework.Base;
using DAO.EntityFramework.Context;
using Entity;

namespace DAO.EntityFramework
{
    public class ClientDao : DAOBase<Client>
    {
        protected override DbSet<Client> GetDbSet(DDSORMDbContext ctx)
        {
            return ctx.Clients;
        }
    }
}
