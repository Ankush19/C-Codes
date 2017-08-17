using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class patternnum
    {
        public void display()
        {
            Console.WriteLine("Enter number");
            int num = Int32.Parse(Console.ReadLine());

            //Console.WriteLine("Enter height");
            //int h = Int32.Parse(Console.ReadLine());
            int count=num-1,k,i;
            int inc = num;
            int dec = num;
            for (k = 1; k <= num; k++)
            {
                for (i = 1; i <= count; i++)
                    Console.Write(" ");
                count--;
                for (i = 1; i <= 2 * k - 1; i++)
                {
                    for (i = 0; i < k; i++)
                    {
                        Console.Write(inc);
                        inc = inc + 1;
                    }
                    for (i = k + 1; i < 3; i++)
                    {
                        Console.Write(dec);
                        dec = dec - 1;
                    }
                    
                }
                Console.WriteLine();
            }

        }
    }
}
