using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class sumofdigits
    {
        public void sum()
        {
            Console.WriteLine("Enter number");
            int num = Int32.Parse(Console.ReadLine());
            
            int sum=0;
            while(num!=0)
            {
                sum = sum + (num % 10);
                num =num / 10;
                
            }
            Console.Write(sum);
        }
    }
}
