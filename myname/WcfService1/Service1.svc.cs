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
        private static List<Student> _studentList;

        public Service1()
        {
            _studentList = new List<Student>();
            this.AddStudent(1,"Hans","Dansk");
        }

        public static List<Student> StudentList
        {
            get
            {
                if (_studentList == null)
                {
                    _studentList = new List<Student>();
                }
                return _studentList;
            }
        }

        public void AddStudent(int StudentID, string name, string Class)
        {
            
            StudentList.Add(new Student(StudentID, name, Class));
        }

        public Student FindStudent(int StudentId)
        {
            Student FoundStudent = StudentList.Find(x => x.GetStudentID.Equals(StudentId));

            return FoundStudent;
        }

        public List<string> GetAllStudents()
        {
            List<string> list = new List<string>();
            foreach (var s in StudentList)
            {
                list.Add(s.GetName);
            }
            return list;
        }

        public void RemoveStudent(int StudentId)
        {
            StudentList.Remove(FindStudent(StudentId));
        }

        public void EditStudent(int StudentID, string Name, string Class)
        {
            RemoveStudent(StudentID);
            StudentList.Add(new Student(StudentID, Name, Class));
        }
    }
}
