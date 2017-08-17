using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    public class Tyre
    {
        public void TyreType()
        {
            Console.WriteLine("Tubeless");

        }
    }

    public class Scooter : Tyre
    {
        public void ScooterTyre()
        {
            Console.WriteLine("Scooter is red");
            TyreType();
        }
    }

    public class Car : Tyre
    {
        public void CarTyre()
        {
            Console.WriteLine("Car is red");
            TyreType();
        }
    }

}
