using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class Test
    {
        public static void Main(String[] args)
        {
            Employee e1 = new Employee("Levi", "Adam", "NY", 15, 20.3);
            Console.WriteLine(e1);
            e1.caculator();
        }
    }
}
