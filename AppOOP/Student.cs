using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AppOOP
{
    class Student
    {
        public Student() { }
        public Student(string stName)
        {
            Name = stName;
        }
        protected string Name;
        public string StudentName
        {
            get
            { return Name; }
            set
            { Name = value; }
        }
        public virtual void Talk()
        {
            if (StudentName.Equals("Minh"))
                MessageBox.Show(" My name is " + this.StudentName + " i am a College Student");
            else if (StudentName.Equals("Dung"))
                MessageBox.Show(" My name is " + this.StudentName + " i am a University Student");
        }
    }
}
