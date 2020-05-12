using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiples
{
    class Multiples
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input number:");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
            }
        }
    }
}
