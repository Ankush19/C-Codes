using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Day8
{
    class Replace
    {
        public void RemoveWhiteSpace(string str)
        {
            string pattern = "\\s+";
            string replacement = " ";
            Regex r = new Regex(pattern);
            string result = r.Replace(str, replacement);
            Console.WriteLine("Original string "+str);
            Console.WriteLine("After removing whitespace"+result);
        }
    }
}
