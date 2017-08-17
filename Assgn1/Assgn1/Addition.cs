using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgn1
{
    class Addition
    {
        public void Sum(int x, int y)
        {
            Console.WriteLine("Sum:" + (x + y));
        }

        public void Sum(int x, int y,int z)
        {
            Console.WriteLine("Sum is {0}", (x + y + z));
        }
    }
}
