using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Calculator
    {
        public void Sum()
        {
            Console.WriteLine("No value");
        }

        public void Sum(int x,int y)
        {
            Console.WriteLine("Sum:"+(x+y));
        }

        public void Sum(float x, float y)
        {
            Console.WriteLine("Sum is {0}", (x + y));
        }
    }
}
