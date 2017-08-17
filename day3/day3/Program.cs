using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using testdemo;
//using cc = testdemo.test;
//using globalvar;


/// <summary>
/// 
/// </summary>
namespace day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //dd d = new dd();
            //d.print();
            //cc.dd obj1= new cc.dd();
            //obj1.print();
            //globalvar.Console obj = new globalvar.Console();
            //obj.WriteLine();
            Console.WriteLine("Main1");
            demo.Program.Main();
            Console.ReadLine();
        }
    }
}

namespace demo
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Main2");

        }
    }
}

/// <summary>
/// global variable creation
/// </summary>
//namespace globalvar
//{
//    class Console
//    {
//        public void WriteLine()
//        {
//            global::System.Console.WriteLine("In custom");
//            global::System.Console.ReadLine();
//        }
//    }
//}
//namespace testdemo
//{
//    namespace test
//    {
//        class dd
//        {
//            public void print()
//            {
//                global::System.Console.Write("yes");
//                global::System.Console.ReadLine();
//            }
//        }
//    }


//}

