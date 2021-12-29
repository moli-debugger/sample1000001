using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("hierarchical inheritance\n");
            productDev productdev = new productDev();
            productdev.EmpID = 1001;
            productdev.EmpName = "sanjeev";
            productdev.Salary = 65000;
            productdev.display();

            juniorDev junior = new juniorDev();
            junior.EmpID = 1901;
            junior.EmpName = "Ravi";
            junior.experience = 2;
            junior.Salary = 50000;
            junior.cal();

            Console.ReadKey();
        }
    }

    public class Employee
    {
        public int EmpID;
        public string EmpName { get; set; }
        public  void sample()
        {
            Console.Write("Hello");
        }
    }
    public class softwareDev : Employee
    {
        private int salary { get; set; }
        public int Salary
        {
            get => this.salary;
            set
            {
                this.salary = value;
            }
        }
        public string EmpName { get; set; }

       
        public void hi()
        {
            Console.Write("hi {0}",EmpName);
        }
    }

    public class juniorDev : Employee
    {
        public int experience;
        private int salary { get; set; }
        public int Salary
        {
            get => this.salary;
            set
            {
                this.salary = value;
            }
        }
        public void cal()
        {
            if (experience < 5)
            {
                Console.WriteLine("You need {0}+ years of experience to switch from junior to senior level. ", 5 - experience);
            }
        }
    }

    class productDev : softwareDev
    {
       public void display()
        {
            Console.WriteLine("Multiline inhertance");
            Console.WriteLine("For both software and product developer package will be: {0}", Salary);
        }
    }


}
