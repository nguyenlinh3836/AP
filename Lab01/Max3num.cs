using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max3int
{
    class Max3num
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Please input 3 number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());
            num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("The biggest number is: {0}", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("The biggest number is: {0}", num2);
            }
            else
            {
                Console.WriteLine("The biggest number is: {0}", num3);
            }
        }
    }
}
