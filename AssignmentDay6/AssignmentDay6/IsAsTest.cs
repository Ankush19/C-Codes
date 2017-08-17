using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentDay6
{
    class IsAsTest
    {
        public void test()
        {
            object[] objects = new object[6];
            objects[0] = new class1();
            objects[1] = new class2();
            objects[2] = "string";
            objects[3] = 23;
            objects[4] = null;
            for (int i = 0; i < objects.Length; ++i)
            {
                int? s = objects[i] as int?;
                if (objects[i] is class1)
                {
                    class1 c1 = objects[i] as class1;
                    c1.print();

                 }
                Console.WriteLine("{0}:",i);
                if (s != null)
                {
                    Console.WriteLine("'"+s+"'");
                }
                else
                    Console.WriteLine("not a string");
            }
        }
    }

    class derived : IsAsTest
    {

    }
}
