using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class diamond
    {
        public void pattern()
        {
            int i,k;
            Console.WriteLine("Enter heigth of diamond");
            int number = Int32.Parse(Console.ReadLine());
            int count = number - 1;
            for (k = 1; k <= number; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * k - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            count = 1;
            for (k = 1; k <= number - 1; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count++;
                for (i = 1; i <= 2 * (number - k) - 1; i++)
                    Console.Write("*");
                Console.WriteLine();
            }
            
        }
    }
}
