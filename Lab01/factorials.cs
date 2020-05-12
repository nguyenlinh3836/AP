using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorials
{
    class factorials
    {
        static void Main(string[] args)
        {
            double fac = 1;
            int i;                            
                for (i = 1; i <21; i++)
                {
                    fac = fac * i;
                Console.WriteLine("{0}! = {1}", i, fac);
            }
                       
           

        }
    }
}
