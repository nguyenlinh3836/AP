using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Employee
    {
        string Firstname;
        string Lastname;
        string Address;
        long sin;
        double salary;
        public Employee(string Firsname,string Lastname,string Address,long sin,double salary)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Address = Address;
            this.sin = sin;
            this.salary = salary;         
        }
        public override string ToString()
        {
            return "Name:" + Lastname + Firstname + "\n" + "Address:" + Address + "\n" + "Salary:" + salary ;
        }
        public void caculator()
        {
            salary = this.salary * 5 / 100;
            Console.WriteLine("New salary is: {0}", salary);
        }
    }
}
