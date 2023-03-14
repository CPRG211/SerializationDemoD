using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SerializationDemoD
{
    [Serializable]
    internal class Student
    {
        private string _name;
        private double _gpa;

        [OptionalField(VersionAdded = 2)]
        private int _age;

        [NonSerialized]
        private string _password;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public double GPA
        {
            get { return _gpa; }
            set { _gpa = value; }
        }

        
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public Student()
        {

        }

        public Student(string name, double gpa, int age, string password)
        {
            _name = name;
            _gpa = gpa;
            _age = age;
            _password = password;
        }
    }
}
