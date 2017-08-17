using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class baseclass
    {
        public virtual void MyMethod()
        {
            Console.WriteLine("Base class");
        }
       
    }
    class Derived : baseclass
    {
        public override void MyMethod()
        {
            Console.WriteLine("Derived class");
        }
    }

}
