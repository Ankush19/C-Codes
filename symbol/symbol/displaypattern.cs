using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class displaypattern
    {
        public void display(short line)
        {
            
            for(short k=0;k<line;k++)
            {
                for (short i = 0; i < line; i++)
                {
                    Console.Write(" ");
                    for (short j = 0; j > line; j++)
                    {
                        Console.Write("*");


                    }
                }
                
            }
            Console.ReadLine();

        }
    }
}
