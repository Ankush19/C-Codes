using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e=new Employee();
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(3,"Ankush"));
            emplist.Add(new Employee(2,"Ank"));
            emplist.Add(new Employee(1,"Nkasds"));
            emplist.Sort();
            foreach (var item in emplist)
            {
                Console.WriteLine(item.empid);
                Console.WriteLine(item.empname);
            }

            
            //Console.WriteLine("Enter a phone number to verify");
            //string phone=Console.ReadLine();
            //VerifyPhoneNumber v = new VerifyPhoneNumber();
            //v.validate(phone);
            //Replace r = new Replace();
            //Console.WriteLine("Enter string to remove whitespace");
            //string str = Console.ReadLine();
            //r.RemoveWhiteSpace(str);
            //Collection1 c = new Collection1();
            //c.add();
            StringBuilder1 s = new StringBuilder1();
            s.append("This");
            s.append("is");
            s.append("sighu");
            s.Insert(3, "ank");
            s.RemoveAt(3);
            string str=s.ToString();
            Console.WriteLine(str);

            Console.ReadLine();

        }
    }
}
