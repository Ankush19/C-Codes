using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    class Program
    {
        public struct coord
        {
            public int x, y;
           
        }
        public struct coord1
        {
            public int x1, y1;
        }

        
        static void Main(string[] args)
        {
            var p = Tuple.Create("ank","as");
            Console.WriteLine(p.Item1);
            var primes = new Tuple< int, int, int, int, int, int,int,
                 Tuple<int>>(2, 3,  7, 11, 13, 16,12,
                 new Tuple<int>(19));
            Console.WriteLine(primes.Rest.Item1);
           


            Console.ReadLine();

        }
    }
}
