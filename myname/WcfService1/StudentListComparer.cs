using System.Collections;
using System.Collections.Generic;

namespace WcfService1
{
    public class StudentListComparer : Comparer<Student>
    {
        public override int Compare(Student x, Student y)
        {
            return x.GetStudentID.CompareTo(y.GetStudentID);
        }
    }
}