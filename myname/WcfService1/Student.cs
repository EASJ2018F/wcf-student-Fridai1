namespace WcfService1
{
    public class Student
    {
        private int _studentID;
        private string _name;
        private string _ClassName;
        
        public Student(int studentId, string Name, string ClassName)
        {
            _studentID = studentId;
            _ClassName = ClassName;
            _name = Name;
        }

        public Student()
        {
            
        }
        public int GetStudentID
        {
            get => _studentID;
        }

        public string GetName
        {
            get => _name;
        }

        public string GetClass
        {
            get => _ClassName;
        }



    }
}