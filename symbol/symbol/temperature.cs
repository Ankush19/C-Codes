using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace symbol
{
    class temperature
    {
        public void CelToFah()
        {
            Console.Write("Enter temperature in celsius");
            int temp = Int32.Parse(Console.ReadLine());
            Console.WriteLine("temperature in celsius{0}", temp);
            Console.WriteLine("temperature in fahrenhiet{0}", (temp * 1.8 + 32));
        }
    }
}
