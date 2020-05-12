using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    class Info
    {
        static void Main(String[]args)
        {
            Console.Write("Enter name:");
            String username = Console.ReadLine();
            Console.Write("Enter address:");           
            String address = Console.ReadLine();
            Console.Write("Enter phone:");
            String phone = Console.ReadLine();
            Console.WriteLine("Username is:" + username);
            Console.WriteLine("Address is:" + address);
            Console.WriteLine("Address is:" + phone);           
        }
    }

