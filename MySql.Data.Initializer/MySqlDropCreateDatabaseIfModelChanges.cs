using System.Data.Entity;

namespace MySql.Data.Initializer
{
    public class MySqlDropCreateDatabaseIfModelChanges<T> : MySqlInitializer<T> where T:DbContext
    {
        protected override bool HandleDataBase(T context)
        {
            return context.Database.CompatibleWithModel(false);
        }
    }
}
