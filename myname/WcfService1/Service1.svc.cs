using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        private  List<Student> _studentList;

        public Service1()
        {
            _studentList = new List<Student>();

            _studentList.Add(new Student(1, "Hans", "Gym"));
            _studentList.Add(new Student(2, "Lars", "Gym"));
            _studentList.Add(new Student(3, "Bent", "Gym"));
        }

        //public static List<Student> StudentList
        //{
        //    get
        //    {
        //        if (_studentList == null)
        //        {
        //            _studentList = new List<Student>();
        //        }
        //        return _studentList;
        //    }
        //}

        public void AddStudent(int studentID, string name, string Class)
        {
           
            _studentList.Add(new Student(studentID, name, Class));
        }

        public Student FindStudent(int StudentId)
        {
            Student FoundStudent = _studentList.Find(x => x.GetStudentID.Equals(StudentId));

            return FoundStudent;
        }

        public List<Student> GetAllStudents()
        {
            return _studentList;
        }

        public void RemoveStudent(int StudentId)
        {
            _studentList.Remove(FindStudent(StudentId));
        }

        public void EditStudent(int StudentID, string Name, string Class)
        {
            RemoveStudent(StudentID);
            _studentList.Add(new Student(StudentID, Name, Class));
        }
    }
}
