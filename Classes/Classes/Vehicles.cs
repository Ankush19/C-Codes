using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Vehicles
    {
        public virtual void DisplayColor()
        {
            Console.WriteLine("red or blue");
        }

        public void DisplayType()
        {
            Console.WriteLine("Type1 or type2");
        }


    }

    public class Vehicle1 : Vehicles
    {
        public new virtual void DisplayColor()
        {
            Console.WriteLine("Red");
        }

        public void DisplayType()
        {
            Console.WriteLine("Type1");
        }

    }

    public class Vehicle2 : Vehicles
    {
        public override void DisplayColor()
        {
            Console.WriteLine("Blue");
        }

        public void DisplayType()
        {
            Console.WriteLine("Type2");
        }

    }

}
