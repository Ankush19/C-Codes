using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Employee:IComparable<Employee>
    {
        public int empid;
        public string empname;

        public Employee()
        { }
        public Employee(int id,string name)
        {
            this.empid = id;
            this.empname = name;
        }

        //public int CompareTo(Employee other)
        //{
        //    return empid.CompareTo(other.empid);
        //}

        public  int CompareTo(Employee other)
        {
            return empname.CompareTo(other.empname);
        }
    }
}
