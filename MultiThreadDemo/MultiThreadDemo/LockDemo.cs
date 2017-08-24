using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadDemo
{
    class LockDemo
    {
        static int n1, n2;

        static void Main(string[] args)
        {
            LockDemo d = new LockDemo();
            
            new Thread(d.divide).Start();
            new Thread(d.divide).Start();

        }

        public void divide()
        {
            Random r = new Random();

            for (long i = 0; i < 100000; i++)
            {
                lock(this)
                {
                    n1 = r.Next(1, 1000);
                    n2 = r.Next(1, 1000);
                    int result = n1 / n2;
                    n1 = 0;
                    n2 = 0;


                }
            }

        }

        
    }
}
