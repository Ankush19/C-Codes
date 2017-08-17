using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay6
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 300000;
            bool num1 = false;
            int num2 = 200000;
            long val = 3000000000;
            int i = (int)val;

            int a = 20;
            object o = a;
            int b = (int)o;
            
            a= 400;
            class1 c1 = new class1();
            class1 c2 = new class1();
            class1 c3 = c1;
            bool b1 = ReferenceEquals(c1, c2);
            bool b3 = ReferenceEquals(c1, c3);

            bool b2 = c1.Equals(c2);
            Console.WriteLine("Reference equals "+b1);
            Console.WriteLine("Reference equals " + b2);
            Console.WriteLine("Reference equals " + b3);

            Console.WriteLine(o);
            Console.WriteLine(i);
            Console.WriteLine("Size of "+typeof(short));
            Console.WriteLine();


            IsAsTest derived = new derived();
            IsAsTest base1 = new IsAsTest();
            derived derivedcopy = (derived)derived;
            //derived derivedcopy2 = (derived)base1;

            
            try
            {

                Console.WriteLine(checked(num * num2));

            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            if (num is int)
            {
                Console.WriteLine("Num is  an object");
            }
            if (num1 is bool)
            {

                Console.WriteLine("bol");
            }
            IsAsTest t = new IsAsTest();
            t.test();
            Console.ReadLine();
        }
    }
}
