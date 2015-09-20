using System.Data.Entity;

namespace MySql.Data.Initializer
{
    public class MySqlDropCreateDatabaseAlways<T> : MySqlInitializer<T> where T:DbContext
    {
        protected override bool HandleDataBase(T context)
        {
            context.Database.Delete();
            context.Database.Create();
            return true;
        }
    }
}
