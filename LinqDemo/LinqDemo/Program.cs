using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> Emplist = new List<Employee>
            {
                new Employee{Id=1, Name="Ankush",Age=23 },
                new Employee{Id=2, Name="Ankush",Age=45 },
                new Employee{Id=3, Name="Ankush2",Age=23 },
                new Employee{Id=4, Name="Ankush3",Age=30 }
            };
            IEnumerable<EmployeePersonal> filter = Employee9Extension.filter(Emplist);
            foreach (EmployeePersonal emp in filter)
            {
                Console.WriteLine("Name:{0},Age:{1}",emp.Name,emp.Age);
            }
            Console.ReadLine();
        }
    }
}
