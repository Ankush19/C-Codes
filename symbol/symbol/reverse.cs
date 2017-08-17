using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class reverse
    {
        public void rev()
        {
            int temp1=0;
            Console.WriteLine("Enter string");
            string str = Console.ReadLine();
            string temp = str;
            int length = str.Length;
            

            for (short i = 0; i < length/2; i++)
            {
                if (str[i] != str[length - 1])
                {
                    temp1 = 1;
                    break;
                }
                length--;
            }
            if (temp1 == 1)
            {
                Console.WriteLine("String is  not palindrome");
            }
            else
            {
                Console.WriteLine("String is palindrome");

            }


        }
    }
}
