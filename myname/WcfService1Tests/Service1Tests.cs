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
            service1.AddStudent(22,"Niko","Fag");

            Assert.AreEqual("Niko", service1.FindStudent(22).GetName);
        }

        [TestMethod()]
        public void FagTest()
        {
            var service1 = new Service1();
            service1.AddStudent(22, "Niko", "Fag");
            Assert.AreEqual("Fag", service1.FindStudent(22).GetClass);
        }

        [TestMethod()]
        public void IdTest()
        {
            var service1 = new Service1();
            service1.AddStudent(22, "Niko", "Fag");
            Assert.AreEqual(22, service1.FindStudent(22).GetStudentID);
        }

        [TestMethod()]
        public void EditTestName()
        {
            var service1 = new Service1();
            service1.AddStudent(22, "Niko", "Fag");
            service1.EditStudent(22, "Lars", "Gym");
            Assert.AreEqual("Lars", service1.FindStudent(22).GetName);
        }

        [TestMethod()]
        public void EditTestClass()
        {
            var service1 = new Service1();
            service1.AddStudent(22, "Niko", "Fag");
            service1.EditStudent(22, "Lars", "Gym");
            Assert.AreEqual("Gym", service1.FindStudent(22).GetClass);
        }
        [TestMethod()]
        public void RemoveTest()
        {
            var service1 = new Service1();
            service1.AddStudent(22, "Niko", "Fag");
            service1.RemoveStudent(22);
           
            Assert.IsNull(service1.FindStudent(22));
        }
        [TestMethod()]
        public void GetAllTest()
        {
            var service1 = new Service1();

            List<Student> name = new List<Student>();
            List<Student> actual = service1.GetAllStudents();

            List<Student> expected = new List<Student>()
            {
                new Student()
                {
                    GetStudentID = 1,
                    GetName = "Hans",
                    GetClass = "Gym"
                },
                new Student()
                {
                    GetStudentID = 2,
                    GetName = "Lars",
                    GetClass = "Gym"
                },
                new Student()
                {
                    GetStudentID = 3,
                    GetName = "Bent",
                    GetClass = "Gym"
                }
            };

            StudentListComparer comparer = new StudentListComparer();




            CollectionAssert.AreEqual(expected, actual, comparer);
            
           // CollectionAssert.AreEquivalent(name, actual);

        }
    }
}