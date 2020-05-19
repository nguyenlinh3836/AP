using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Student : Person
    {
        private string enrolled;

        public Student(string enrolled, string phone , string name, string email): base(name, phone, email)
        {
            this.enrolled = enrolled;
        }

        public string Penroll
        {
            get { return enrolled; }
            set { enrolled = value; }
        }

    }
}
