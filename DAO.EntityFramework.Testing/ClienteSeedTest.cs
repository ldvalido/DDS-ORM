using Entity;
using FizzWare.NBuilder;
using NUnit.Framework;

namespace DAO.EntityFramework.Testing
{
    [TestFixture]
    public class ClienteSeedTest
    {
        [Test]
        public void TestBasicCreation()
        {
            var c = Builder<Client>.CreateNew().Build();

            var clientDao = new ClientDao();

            clientDao.Add(c);
        }
    }
}
