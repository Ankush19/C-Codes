using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadDemo
{
    class MutexDemo
    {
        static void Main(string[] args)
        {
            using (var m1=new Mutex(false,"TestMutex"))
            {
                if (!m1.WaitOne(5000, false))
                {
                    Console.WriteLine("Already instance running");
                    Console.ReadLine();
                    return;
                }
                Console.WriteLine("App running");
                Console.ReadLine();
            }
        }

    }
}
