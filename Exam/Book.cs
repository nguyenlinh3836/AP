using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Book : Product
    {
        public Book(int id, string name, double price, string producer) : base(id, name, price, producer)
        {
            this.price = price;
        }
        public override double computeTax()
        {
           return price * 8 / 100;
        }
    }
}
