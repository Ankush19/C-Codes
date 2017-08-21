using System;
using System.Collections;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day8
{
    class Collection1
    {
        public void add()
        {
            ArrayList a = new ArrayList();
            a.Add("Ankush");
            a.Add(1);
            a.Add("sdasasa");
            a.RemoveAt(2);
            int index = a.IndexOf("1Ankush");
            if (index != -1)
            {

                a[index] = "adasa"; 


            }
            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
        }
    }
}
