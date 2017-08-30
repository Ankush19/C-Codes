using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeToDb;

namespace ConsoleCodeToDb
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var dept = new DepartmentContext())
            {
                Console.WriteLine("My department");
                var deptobj = new Department {Id=1,Name="Comp",Location="pune" };
                dept.Departments.Add(deptobj);
                dept.SaveChanges();
                Console.WriteLine("record add");
            }
            Console.ReadLine();
        }
    }
}
