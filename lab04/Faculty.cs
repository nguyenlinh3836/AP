using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    public class Faculty : Employee
    {
        private int hour;
        private string rank;

        public Faculty(int hour, string rank,int department,double salary,string datahired)
            : base(department,salary,datahired)
        {
            this.hour = hour;
            this.rank = rank;
        }

        public override void CaculateVacation()
        {
            if (this.hour >= 3)
            {
                Console.WriteLine("Has 5 week");
            } else if (this.hour >= 3 && rank == "Senior Lecturer") {
                Console.WriteLine("Has 6 week ");
            } else
            {
                Console.WriteLine("Has 4 week ");
            }
        }
        public override void CaculateBonus()
        {
            double CaculateBonus =  1000 + 0.05 * salary;
        }

    }
}
