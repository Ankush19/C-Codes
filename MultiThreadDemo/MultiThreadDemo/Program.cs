using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread ob2 = new Thread(Function2);
            //ob2.Start();

            ThreadPool.QueueUserWorkItem(Function2);

            Console.WriteLine("Main thread");
            Console.ReadLine();
            

            //Thread objthread = new Thread(Function1);
            //objthread.IsBackground = true;
            //objthread.Start();

            
            
            //Parallel.For(0, 1000000, x => Function1());
           
        }

        private static void Function1(object state)
        {
            Console.WriteLine("Im a thread pool");
        }

        //static void Function1()
        //{
        //    string x = "aa";
        //    Console.WriteLine(x);
            
        //}

        private static void Function2(object state)
        {
            string x = "bb";
            Console.WriteLine(x);
           
        }
    }
}
