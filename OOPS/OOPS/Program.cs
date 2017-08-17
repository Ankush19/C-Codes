using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    class Program
    {
        static void Main(string[] args)
        {
             Dog d = new Dog();
            Scooter sc = new Scooter();
            Calculator calc = new Calculator();
            baseclass objbase;
            Derived objder = new Derived();
            objbase = objder;
            objbase.MyMethod();
            
            calc.Sum(4.0f,5.0f);
            sc.ScooterTyre();
            Car c = new Car();
            c.TyreType();
             clsabstract thePet = d;
             thePet.eat();
             d.eat();
             thePet.sound();
             Console.ReadLine();
        }
    }
}
