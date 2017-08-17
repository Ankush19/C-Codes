using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class binary
    {
        public void tobin()
        {
            Console.WriteLine("Enter number");
            int num = Int32.Parse(Console.ReadLine());
            string rem="";
            while (num >= 1)
            {
                int quo = num / 2;
                 rem += (num%2).ToString();
                num = quo;
            }
            string bin = "";
            for (int i = rem.Length; i >=0; i++)
            {
                bin = bin + rem[i];
            }

            Console.WriteLine(bin);

        }
    }
}
