using Entity;
using FizzWare.NBuilder;
using NUnit.Framework;

namespace DAO.EntityFramework.Testing
{
    [TestFixture]
    public class SKUSeedTest
    {
        [Test]
        public void TestBasicSeed()
        {
            var s = Builder<SKU>.CreateNew().Build();

            var skuDao = new SKUDao();

            skuDao.Add(s);
        }
    }
}
