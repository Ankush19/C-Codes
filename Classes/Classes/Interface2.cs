using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    interface IVehicle
    {
          void DisplayColor();

         void DisplayType();
       
    }

    public class IVehicle1 : IVehicle
    {
        public  void DisplayColor()
        {
            Console.WriteLine("Red");
        }

        public void DisplayType()
        {
            Console.WriteLine("Type1");
        }
        public void specific()
        {
            Console.WriteLine("something");
        }

    }

    public class IVehicle2 : IVehicle
    {
        public  void DisplayColor()
        {
            Console.WriteLine("Blue");
        }

        public void DisplayType()
        {
            Console.WriteLine("Type2");
        }

    }

}
