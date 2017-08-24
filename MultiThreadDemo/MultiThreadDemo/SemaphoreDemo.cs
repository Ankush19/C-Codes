using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreadDemo
{
    class SemaphoreDemo
    {
        static Semaphore s1 = null;
        static void Main(string[] args)
        {
            try
            {
                s1 = Semaphore.OpenExisting("TestDemo");
            }
            catch (Exception)
            {
                s1 = new Semaphore(3, 3, "TestDemo");
            }

            Console.WriteLine("Acquiring...");
            s1.WaitOne();
            Console.WriteLine("Acquired");
            Console.ReadLine();
            s1.Release();


        }
     }
}
