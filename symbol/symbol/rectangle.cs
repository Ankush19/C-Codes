using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class rectangle
    {
        public void rect()
        {
            Console.WriteLine("Enter number");
            int num = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if ( j == 1 && i == 1  )
                    {
                        Console.Write(" ");
                    }
                    else
                        Console.Write(num);
                }
                Console.WriteLine();
            }
        }
    }
}
