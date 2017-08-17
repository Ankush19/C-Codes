using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assgn1
{
   public abstract class Birds
    {
        public void walk()
        {
            Console.WriteLine("bird walking");

        }


    }

   public  class bird1 : Birds
    {
        
        public void fly()
        {
            Console.WriteLine("Bird1 fying");
        }
       
        
    }

    class bird2 : Birds
    {
        
        public void sing()
        {
            Console.WriteLine("Bird2 fying");
        }


    }
}
