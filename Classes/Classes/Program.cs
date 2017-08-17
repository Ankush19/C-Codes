using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //PartialClass1 p = new PartialClass1();
            //p.display();
            //p.display2();
            //float area=StaticClass.area(23);
            //Console.WriteLine(area);
            string value="in the field";
             value.Uppercase();
            //string value1="abc".UpperCaseFirstletter();
            Console.WriteLine(value);
            //Console.WriteLine(value1);
            //IEmployee emp1 = new Employee1();
            //emp1.DisplayEmployee();
            //IEmployee emp2 = new Employee2();
            //emp2.DisplayEmployee();
            //DontKnow(emp1);
            // Console.WriteLine("Enter two numbers" );
            //int num1=Int32.Parse(Console.ReadLine());
            // int num2 = Int32.Parse(Console.ReadLine());
            //Console.WriteLine("Enter string");
            //string str = Console.ReadLine();
            //str.UpperCase();
            //Console.WriteLine(str);
            //Swap s = new Swap();
            //s.swapnum(num1,num2);
            //s.tab(num1);
            //s.removevowel(str);
            //Vehicles v = new Vehicles();
            //v.DisplayColor();
            //Vehicles v1 = new Vehicle2();
            //v1.DisplayColor();
            //v1.DisplayType();
            IVehicle1 v1 = new IVehicle1();
            v1.DisplayColor();
            v1.DisplayType();
            v1.specific();
            //Rectangle.area(3,4);
            Console.ReadLine();

        }
        //public static void DontKnow(IEmployee e)
        //{
        //    e.DisplayEmployee();
        //}
    }
}
