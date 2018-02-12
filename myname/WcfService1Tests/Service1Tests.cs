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
            var service1 = new Service1();

            Assert.AreEqual("Nikolai", service1.MyName());
        }

        [TestMethod()]
        public void GetMyEmailTest()
        {
            var service1 = new Service1();

            Assert.AreEqual("email", service1.GetMyEmail());
        }

        [TestMethod()]
        public void GetMyAdresseTest()
        {
            var service1 = new Service1();

            Assert.AreEqual("adresse 1", service1.GetMyAdresse());
        }
    }
}