using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfService1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        [TestMethod()]
        public void MyNameTest()
        {
            using (var Client = new Service1Tests())
            {
                Assert.AreEqual("Nikolai", Client.MyNameTest());
            }
        }

        [TestMethod()]
        public void GetMyEmailTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetMyAdresseTest()
        {
            Assert.Fail();
        }
    }
}