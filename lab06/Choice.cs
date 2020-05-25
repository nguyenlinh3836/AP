using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Customer;
using Order;

namespace Customer
{
    class Customer_detail
    {
        public string customerName;
        public void getName()
        {
            Console.WriteLine("Input your name:");
            customerName = Console.ReadLine();
        }
    }    
}
namespace Order
{
    class grocery_Item
    {
        public void order_grocery()
        {
        Customer_detail c1 = new Customer_detail();
        c1.getName();
        Console.WriteLine("Hello {0}", c1.customerName);
        Console.WriteLine("You have ordered grocery items");
        }       
    }
    class bakery_product
    {
        public void order_bakery()
        {
            Customer_detail c2 = new Customer_detail();
            c2.getName();
            Console.WriteLine("Hello {0}", c2.customerName);
            Console.WriteLine("You have ordered bakery product");
        }
    }
}
class OrderTest
{
    public static void Main()
    {
        string choice;
        Console.WriteLine("Choose your Order:  1- Grocery Item 2- Bakery products ");
        choice = Console.ReadLine();
        if (choice == "1")
        {
            grocery_Item objgrocery = new grocery_Item();
            objgrocery.order_grocery();
        }
        else
        {
            if (choice == "2")
            {
                bakery_product objBakery = new bakery_product();
                objBakery.order_bakery();
            }
            else
            {
                Console.WriteLine("Enter either 1 or 2");
            }
        }
    }
}
   

