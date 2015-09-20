using System.Data.Entity;
using MySql.Data.Initializer;
using NUnit.Framework;

namespace DAO.EntityFramework.Testing
{
    [SetUpFixture]
    public class SetupFixture
    {
        [SetUp]
        public void SetUp()
        {
            DbConfiguration.SetConfiguration(new MySqlConfiguration());
        }
    }
}
