using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class leapyear
    {
        public void findleap()
        {
            Console.WriteLine("Enter year");
            int year = Int32.Parse(Console.ReadLine());
            if (year % 4 == 0 || year % 40 == 0)
            {
                Console.WriteLine("{0}is a leap year", year);
            }
            else
            {
                Console.WriteLine("Not leap year");
            }
        }
    }
}
