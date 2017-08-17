using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class alternate
    {
        public void rows()
        {
            Console.WriteLine("Enter number");
            int num = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < 4; i++)
            {
                int j;
                if (i % 2 == 0)
                {
                    j = 0;
                    while (j != 4)
                    {
                        Console.Write(num);
                        j++;
                    }

                }
                else
                {
                    j = 0;
                    while (j != 4)
                    {
                        Console.Write(num+" ");
                        j++;
                    }

                }
                Console.WriteLine();

            }
        }
    }
}
