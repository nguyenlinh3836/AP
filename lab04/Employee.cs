using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public abstract class Employee : Person
    {
        protected int department;
        protected double salary;
        protected string datahired;

        public Employee(int department, double salary, string datahired)
        {
            this.department = department;
            this.salary = salary;
            this.datahired = datahired;
        }
        public Employee(int department, double salary, string datahired,string phone, string name,string email) 
            : base(name,phone,email)
        {
            this.department = department;
            this.salary = salary;
            this.datahired = datahired;
        }
        public int Pdepart
        {
            set { department = value; }
            get { return department; }
        }
         public double Psalary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string Pdatahired
        {
            get { return datahired; }
            set { datahired = value; }
        }

        public abstract void CaculateBonus();
        public abstract void CaculateVacation();

    }
}
