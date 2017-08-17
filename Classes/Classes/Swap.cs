using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Swap
    {
        public void swapnum(int n1,int n2)
        {
            n1 = n1 + n2;
            n2 = n1 - n2;
            n1 = n1-n2;
            Console.WriteLine(n1);
            Console.WriteLine(n2);

        }

        public void tab(int n1)
        {
            for (int i= 1;  i<=10;i++)

            Console.WriteLine(n1 * i);
        }

        public void removevowel(string s)
        {
            string vowels="aeiouAEIOU";
            string name = new string(s.Where(c => !vowels.Contains(c)).ToArray());
            Console.WriteLine(name);

        }
    }
}
