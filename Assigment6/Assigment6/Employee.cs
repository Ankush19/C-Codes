using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment6
{
    class Employee
    {
        private int id;
        private string name, dname, pname;
        public int ID1 { get; set; }
        public string NAME { get; set; }
        public string DEPTNAME { get; set; }
        public string PROJNANE { get; set; }

        static List<Employee> EmpCollection = new List<Employee>();

        public Employee()
        {

        }

        public Employee(int id,string name,string dname,string pname)
        {
           this.ID1=id;
           this.NAME=name;
           this.DEPTNAME=dname;
           this.PROJNANE=pname;
           EmpCollection.Add(this);


        }

        public void add()
        {

            
            EmpCollection.Add(new Employee (2,"ad","adas","asdsad"));
            EmpCollection.Add(new Employee
            {
                ID1=3,
                NAME = "test",
                PROJNANE="dsasa",
                DEPTNAME="aaa"

            });
               
                if (EmpCollection.Any(c => c.ID1 == 1))
                {
                foreach (var v in EmpCollection)
                {


                    Console.WriteLine(v.ID1);
                    Console.WriteLine(v.NAME);
                }
                }
            
            var emplist = EmpCollection.Where(c => c.ID1 == 1).Select(c => new {
                NAME=c.NAME,
                DEPTNAME=c.DEPTNAME
            }).FirstOrDefault();
            EmpCollection.RemoveAll(c=>(c.NAME=="test"));
            if (EmpCollection.TrueForAll(c => (c.NAME == "!test")))

            {
                Console.WriteLine("No test ");
            }
            Console.ReadLine();
            Console.WriteLine(emplist);
            Console.ReadLine();

            
        }
    }
}
