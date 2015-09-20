using System.Data.Entity;
using DAO.EntityFramework.Base;
using DAO.EntityFramework.Context;
using Entity;

namespace DAO.EntityFramework
{
    
    public class SKUDao : DAOBase<SKU>
    {
        protected override DbSet<SKU> GetDbSet(DDSORMDbContext ctx)
        {
            return ctx.SKUs;
        }
    }
}
