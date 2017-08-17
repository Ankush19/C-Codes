using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class patterns
    {
        public void display()
        {
            Console.WriteLine("Enter number");
            int num = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter width");
            int w = Int32.Parse(Console.ReadLine());
            int count = w;
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < count; j++)
                {
                    Console.Write(num);
                }
                count--;
                for (int j = 0; j < count; j++)
                {
                    Console.Write("");
                }
                Console.WriteLine();
            }
        }
    }
}
