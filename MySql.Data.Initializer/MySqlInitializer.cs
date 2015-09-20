using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace MySql.Data.Initializer
{
    
    public abstract class MySqlInitializer <T> : IDatabaseInitializer<T> 
        where T : DbContext
    {
        /// <summary>
        /// Schema Name where the migration table should be found
        /// </summary>
        public string TableSchema { get; set; }
        
        //Doc: http://www.asp.net/identity/overview/getting-started/aspnet-identity-using-mysql-storage-with-an-entityframework-mysql-provider
        public void InitializeDatabase(T context)
        {
            var executeMigratoin = HandleDataBase(context);
            if (executeMigratoin)
            {
                ExecuteMigration(context);   
            }
        }
        /// <summary>
        /// Carroy Out migration of the model
        /// </summary>
        /// <param name="context"></param>
        void ExecuteMigration(T context)
        {

            var query = $@"SELECT COUNT(*) FROM information_schema.tables WHERE 
                        table_schema = '{TableSchema}'
                        AND table_name = '__MigrationHistory'";
            if (string.IsNullOrEmpty(TableSchema))
            {
                query = @"SELECT COUNT(*) FROM information_schema.tables WHERE 
                        table_name = '__MigrationHistory'";
            }

            // query to check if MigrationHistory table is present in the database 
            var migrationHistoryTableExists = ((IObjectContextAdapter)context).ObjectContext.ExecuteStoreQuery<int>(query);

            // if MigrationHistory table is not there (which is the case first time we run) - create it
            if (migrationHistoryTableExists.FirstOrDefault() == 0)
            {
                context.Database.Delete();
                context.Database.Create();
            }
        }
        /// <summary>
        /// Perform the handling of database and returns if the migration process should be executed.
        /// </summary>
        /// <param name="context"></param>
        protected abstract bool HandleDataBase(T context);
    }
}
