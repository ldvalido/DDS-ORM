using System.Data.Entity;
using System.Data.Entity.Migrations.Model;
using DAO.EntityFramework.Context;

namespace DAO.EntityFramework.Base
{
    public abstract class DAOBase <T> where T : class
    {
        internal DDSORMDbContext GetCtx()
        {
            return new DDSORMDbContext();   
        }

        protected abstract DbSet<T> GetDbSet(DDSORMDbContext ctx);

        public void Add(T entity)
        {
            var ctx = GetCtx();
            GetDbSet(ctx).Add(entity);
            ctx.SaveChanges();
        }
    }
}
