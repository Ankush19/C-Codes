using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class findflarge
    {
        public void find()
        {
            Console.WriteLine("Enter 3 numbers");
            int a = Int32.Parse(Console.ReadLine());
            int b = Int32.Parse(Console.ReadLine());
            int c = Int32.Parse(Console.ReadLine());
            if (a > b && a > c)
            {
                Console.WriteLine("{0} is largest", a);
            }

            else if (b > a && b > c)
            {
                Console.WriteLine("{0} is largest", b);
            }

            else
                Console.WriteLine("{0} is largest", c);


        }
    }
}
