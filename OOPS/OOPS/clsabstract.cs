using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    abstract class clsabstract
    {
        public abstract void eat();
        public void sound()
        {
            Console.WriteLine("Animal sound");
        }
    }

    class Dog : clsabstract
    {
        public override void eat()
        {
            Console.WriteLine("Dog can eat");
        }
    }
}
