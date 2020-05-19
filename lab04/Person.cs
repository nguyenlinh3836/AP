using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public  class Person
    {
        protected string name;
        protected string phone;
        protected string email;

        protected Person() { }
        protected Person(String name, string phone, string email)
        {
            this.name = name;
            this.phone = phone;
            this.email = email;
        }

        public string Pname
        {
            get { return name; }
            set { name = value; }
        }
        public string Pphone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Pemail
        {
            get { return email; }
            set { email = value; }
        }
    }
}
