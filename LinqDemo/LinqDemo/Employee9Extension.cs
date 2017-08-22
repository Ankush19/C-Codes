using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqDemo
{
    public static class Employee9Extension
    {
        public static IEnumerable<EmployeePersonal> filter(List<Employee> employees)
        {
            //return Select<Employee, EmployeePersonal>(Where<Employee>(employees, emp => emp.Age > 26),
            //    item => new EmployeePersonal() { Age = item.Age, Email = item.Email, Name = item.Name, Phone = item.Phone });
            // return employees.Where(emp => emp.Age > 25).Select(item => new EmployeePersonal() { Age = item.Age, Email = item.Email, Name = item.Name, Phone = item.Phone });
            // return from emp in employees where emp.Age > 25 select new EmployeePersonal() { Age = emp.Age, Email = emp.Email, Name = emp.Name, Phone = emp.Phone };
            // return from emp in employees where emp.Age > 25 select new EmployeePersonal() { Age = emp.Age,  Name = emp.Name };
            return from emp in employees group emp by new { emp.Name} into grouping select new EmployeePersonal {Name=grouping.Key.Name };
        }

        //private static IEnumerable<TInput> Where<TInput>(this IEnumerable<TInput> source, Func<TInput, bool> whereClause)
        //{
        //    foreach (TInput item in source)
        //    {
        //        if (whereClause(item))
        //        {
        //            yield return item;
        //        }
        //    }
        //}

        //private static IEnumerable<TOutput> Select<TInput, TOutput>(this IEnumerable<TInput> source, Func<TInput, TOutput> selectClause)
        //{
        //    List<TOutput> destination = new List<TOutput>();
        //    foreach (TInput item in source)
        //    {
        //        destination.Add(selectClause(item));
        //    }
        //    return destination;
        //}
    }
}
