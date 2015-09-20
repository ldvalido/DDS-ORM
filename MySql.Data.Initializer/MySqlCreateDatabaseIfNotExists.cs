using System.Data.Entity;

namespace MySql.Data.Initializer
{
    public class MySqlCreateDatabaseIfNotExists<T> : MySqlInitializer<T> where T : DbContext
    {
        protected override bool HandleDataBase(T context)
        {
            var returnValue = context.Database.Exists();
            context.Database.CreateIfNotExists();
            return returnValue;
        }
    }
}
