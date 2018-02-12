using Microsoft.VisualStudio.TestTools.UnitTesting;
using WcfService1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        
       
        [TestMethod()]
        public void FindTest()
        {
            var service1 = new Service1();
            service1.AddStudent(2,"Niko","Fag");

            Assert.AreEqual("Niko", service1.FindStudent(2).GetName);
        }

        [TestMethod()]
        public void FagTest()
        {
            var service1 = new Service1();
            service1.AddStudent(2, "Niko", "Fag");
            Assert.AreEqual("Fag", service1.FindStudent(2).GetClass);
        }

        [TestMethod()]
        public void IdTest()
        {
            var service1 = new Service1();
            service1.AddStudent(2, "Niko", "Fag");
            Assert.AreEqual(2, service1.FindStudent(2).GetStudentID);
        }

        [TestMethod()]
        public void EditTestName()
        {
            var service1 = new Service1();
            service1.AddStudent(2, "Niko", "Fag");
            service1.EditStudent(2, "Lars", "Gym");
            Assert.AreEqual("Lars", service1.FindStudent(2).GetName);
        }

        [TestMethod()]
        public void EditTestClass()
        {
            var service1 = new Service1();
            service1.AddStudent(2, "Niko", "Fag");
            service1.EditStudent(2, "Lars", "Gym");
            Assert.AreEqual("Gym", service1.FindStudent(2).GetClass);
        }
        [TestMethod()]
        public void RemoveTest()
        {
            var service1 = new Service1();
            service1.AddStudent(2, "Niko", "Fag");
            service1.RemoveStudent(2);
           
            Assert.IsNull(service1.FindStudent(2));
        }
        [TestMethod()]
        public void GetAllTest()
        {
            var service1 = new Service1();

            List<Student> name = new List<Student>();
            List<Student> actual = service1.GetAllStudents();

            name.Add(new Student(1, "Hans", "Dansk"));
            name.Add(new Student(4, "Lars", "Mat"));
            name.Add(new Student(3, "Bent", "Tysk"));
            
            

            CollectionAssert.AreEqual(name, actual);
        }
    }
}