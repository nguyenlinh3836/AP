using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_lab01
{
    class BusinessEmployee :Employee
    {
        public double bonusBudget = 1000;
        public BusinessEmployee(string Name):base(Name, 50000)
        {

        }
        public override string employeeStatus()
        {
            return toString() + " with a budget of " + this.bonusBudget;
        }
    }
}
