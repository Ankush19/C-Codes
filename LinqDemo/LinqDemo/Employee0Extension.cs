using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public static class Employee0Extension
    {
        public  static IEnumerable<EmployeePersonal> filter(List<Employee> emplist)
        {
            return Select(Where(emplist));
        }

        private static IEnumerable<Employee> Where(IEnumerable<Employee> emplist)
        {
            List<Employee> dest = new List<Employee>();
            foreach (Employee emp in emplist)
            {
                if (emp.Age>25)
                {
                    dest.Add(emp);
                }
            }
            return dest;
        }

        private static IEnumerable<EmployeePersonal> Select(IEnumerable<Employee> emplist)
        {
            List<EmployeePersonal> dest = new List<EmployeePersonal>();
            foreach (Employee emp in emplist)
            {
                dest.Add(new EmployeePersonal { Age=emp.Age,Name=emp.Name});
            }
            return dest;
        }
    }

}
