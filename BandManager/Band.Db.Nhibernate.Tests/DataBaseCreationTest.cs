using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Band.Db.Nhibernate.Tests
{
    [TestFixture]
    public class DataBaseCreationTest
    {
        [Test]
        public void Test()
        {
            DataBase.CreateDatabase();
        }
    }
}
