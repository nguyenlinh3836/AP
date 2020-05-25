using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Person
    {
        string name;
        double salary;
        double bonus;
        public Person(string name , double salary , double bonus)
        {
            this.name = name;
            this.salary = salary;
            this.bonus = bonus;            
        }
        public Person() { }
        public double Psalary
        {
            get { return salary; }
            set { salary = value; }
        }
        public double Pbonus
        {
            get { return bonus; }
            set { bonus = value; }
        }
        public string Pname
        {
            get { return name; }
            set { name = value; }
        }

        
        public class SalaryEx : ApplicationException
        {
            public SalaryEx() : base("Enter salary more than 60.000"){}
        }
        public class BonusEx : ApplicationException
        {
            public BonusEx() : base("Enter bonus more than 10.000") { }
        }
    
}

    class Program
    {
        static void Main()
        {
            try
            {
                Person p1 = new Person();
                Console.WriteLine("Input Name");
                string strName = Console.ReadLine();
                p1.Pname = strName;
                Console.WriteLine("input salary");
                double salary = Convert.ToDouble(Console.ReadLine());
                p1.Psalary = salary;
            if (salary <= 60000)
            {
                throw new Person.SalaryEx();
            }
            Console.WriteLine("input bonus:");
                double bonus = Convert.ToDouble(Console.ReadLine());
                p1.Pbonus = bonus;                
                if(bonus < 10000) {
                throw new Person.BonusEx();
                }
            Console.WriteLine("Name: " + p1.Pname + "Salary: " + p1.Psalary + "Bonus: " + p1.Pbonus);

            } 
        catch (Person.SalaryEx Objinputsalary )
            {
            Console.WriteLine(Objinputsalary.Message);
            }
        catch(Person.BonusEx Objinputbonus)
        {
            Console.WriteLine(Objinputbonus.Message);
        }         



        }
    }

