using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        void AddStudent(int StudentID, string name, string Class);
        [OperationContract]
        Student FindStudent(int Studentid);
        [OperationContract]
        List<Student> GetAllStudents();
        [OperationContract]
        void RemoveStudent(int StudentId);
        [OperationContract]
        void EditStudent(int StudentID, string Name, string Class);


    }
}
