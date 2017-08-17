using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    interface IEmployee
    {
        void GetSalary();
        void DisplayEmployee();
    }
    public class Employee1 : IEmployee
    {
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee1");
        }

        public void GetSalary()
        {
            Console.WriteLine("Employee1 sal");
        }
    }

    public class Employee2 : IEmployee
    {
        public void DisplayEmployee()
        {
            Console.WriteLine("Employee2");
        }

        public void GetSalary()
        {
            Console.WriteLine("Employee2 sal");
        }
    }

}
