using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace DAO.EntityFramework.Context
{
    public class MySqlInitializer<T> : IDatabaseInitializer<DbContext> 
        where T: IDatabaseInitializer<DbContext> 
    {
        public void InitializeDatabase(DbContext context)
        {
            var initilizer = Activator.CreateInstance<T>();

            initilizer.InitializeDatabase(context);
            
            // query to check if MigrationHistory table is present in the database 
            var migrationHistoryTableExists = ((IObjectContextAdapter)context).ObjectContext.ExecuteStoreQuery<int>(
                $"SELECT COUNT(*) FROM information_schema.tables WHERE table_schema = '{"[Insert your database schema here - such as 'users']"}' AND table_name = '__MigrationHistory'");

            // if MigrationHistory table is not there (which is the case first time we run) - create it
            if (migrationHistoryTableExists.FirstOrDefault() == 0)
            {
                context.Database.Delete();
                context.Database.Create();
            }
        }
    }
}
