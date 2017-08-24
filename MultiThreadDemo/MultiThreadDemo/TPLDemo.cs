using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadDemo
{
    class TPLDemo
    {
        static void Main(string[] args)
        {
            Task t1 = new Task(Function);
            t1.Start();
            t1.Wait();
            Console.WriteLine("hi");
            Task t2 = new Task(Function2);
            t2.Start();
            Console.ReadLine();
                
        }

        private static void Function2()
        {
            Console.WriteLine("Task2");
        }

        private static void Function()
        {
            Console.WriteLine("Task1");
        }
    }
}
