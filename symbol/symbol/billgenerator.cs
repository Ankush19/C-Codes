using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class billgenerator
    {
        public void input()
        {
            double total = 0;
            Console.WriteLine("Enter id");
            int id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter unit");
            int units = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Name {0}",name);
            Console.WriteLine("ID is {0}",id);
            Console.WriteLine("unit {0}",units);

            if (units < 199)
            {
               total = total + (units * 1.20);
                Console.WriteLine("Amount charges at 1.20 is {0}",total);
            }

            else if (units >200 && units<400)
            {
                total = total + (units * 1.50);
                Console.WriteLine("Amount charges at 1.50 is {0}", total);

            }

            if (units > 400 && units <600)
            {
                total = total + (units * 1.80);
                Console.WriteLine("Amount charges at 1.80 is {0}", total);

            }

            if (total > 400)
            {
                double surface = total * .15;
                double totals=0;
                totals = total + (surface);
                Console.WriteLine("Surface charges {0}", surface);
                Console.WriteLine("Amount paid by customer is {0}", totals);


            }

        }

    }
}
