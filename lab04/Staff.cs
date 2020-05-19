using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Staff : Employee
    {
        private string title;
        private int year;
        public Staff (string title, int year, int department, double salary, string datahired) : base(department,salary,datahired)
        {
            this.title = title;
            this.year = year;
        }
        public override void CaculateBonus()
        {
            double Cal = 0.06 * salary;
        }
        public override void CaculateVacation()
        {
           if(year >= 5)
            {
                Console.WriteLine("Has 4 week");
            } else
            {
                Console.WriteLine("Has 3 week");
            }
        }
    }
}
