using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public static class ExtensionMethod
    {
        public static string UpperCaseFirstletter(this string value)
        {
            if (value.Length > 0)
            {
                string del = " " ;
                char[] array;
                string[] substring=value.Split(del.ToCharArray());
                
                foreach (var sub in substring)
                {
                     array = sub.ToCharArray();

                    array[0] = char.ToUpper(array[0]);
                    

                    return new string(array);

                }
            }
            return value;
        }

        public static void Uppercase(this string value)
        {
            string[] sub = value.Split(' ');
            foreach (var word in sub)
            {
                string str=UpperCaseFirstletter(word);
                Console.Write(str+" ");
            }
           
        }
    }
}
