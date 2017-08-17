using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgn1
{
    class Program
    {
        static void Main(string[] args)
        {
            //bird1 b = new bird1();
            //b.walk();
            //b.fly();
            //bird2 b2 = new bird2();
            //b2.walk();
            //b2.sing();
            //Addition add2 = new Addition();
            //int count = Int32.Parse(Console.ReadLine());
            //if(count ==2)
            //{
              //  int num1 = Int32.Parse(Console.ReadLine());

                //int num2 = Int32.Parse(Console.ReadLine());
                //add2.Sum(num1,num2);

            //}
            //Console.WriteLine("Enter notification medium");
            //String type = Console.ReadLine();
            //Notification n1 = null;
            
            //objcreate obj = new objcreate();
            //n1 = obj.obj1(type);
            //n1.notify();

            Console.WriteLine("Enter employee");
            String type1 = Console.ReadLine();
           Employee e1;
           

            objcreat objemp = new objcreat();
            e1 = objemp.obj2(type1);
            e1.getsal();
            e1.display();

            Console.ReadLine();

        }
    }
}
