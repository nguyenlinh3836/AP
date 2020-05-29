using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double sum2 = 0;
            Product[] products = new Product[6];
            Book[] books = new Book[3];
            books[0] = new Book(1, "Red Dragon", 5000, "Global");
            books[1] = new Book(2, "Harry Potter", 4500, "NY");
            books[2] = new Book(3, "Pinochio", 2000, "LA");
            MobilePhone[] phones = new MobilePhone[3];
            phones[0] = new MobilePhone(1, "Samsung", 1000, "KR");
            phones[1] = new MobilePhone(2, "Iphone", 1999, "USA");
            phones[2] = new MobilePhone(3, "Nokia", 300, "SW");
            
            for (int i = 0; i < books.Length; i++)
            {                               
                sum += books[i].computeTax();                
            }
            for (int j = 0; j < phones.Length; j++)
            {
                sum2 += phones[j].computeTax();
            }
            Console.WriteLine("Total tax book is : " + sum);
            Console.WriteLine("Total tax mobile phone is :" + sum2);
           


        }
    }
}
