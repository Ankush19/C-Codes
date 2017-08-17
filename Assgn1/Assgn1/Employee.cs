using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgn1
{
    class Employee
    {
        int id;
        String name;
        public Employee(int id, String name)
        {
            this.name = name;
            this.id = id;
        }
        public virtual void getsal()
        {

        }

        public void display()
        {
            Console.WriteLine("Name:"+this.name);
            Console.WriteLine("ID:" + this.id);


        }
    }

    class manager : Employee
    {
        int salman;
        public manager(int id,String name,int sal):base(id,name)
        {
            this.salman = sal;
        }
        public override void getsal()
        {

            Console.WriteLine("Manager");
           
            Console.WriteLine("Sal:" + this.salman);

        }
    }

    class clerk : Employee
    {
        int salcl;
        public clerk(int id, String name, int sal):base(id,name)
        {
            this.salcl = sal;
        }
        public override void getsal()
        {
            Console.WriteLine(" clerk");
            
            Console.WriteLine("Sal:" + this.salcl);

        }
    }

    class objcreat
    {
        public Employee obj2(String type)
        {
            if (type == "Manager")
            {
                Employee man = new manager(101,"Ankush",10000);
                return man;
            }
            if (type == "Clerk")
            {
                Employee cl = new clerk(201,"ADS",4555);
                return cl;
            }
            else
                return new Employee(32,"dasdsa");
        }
    }
}
