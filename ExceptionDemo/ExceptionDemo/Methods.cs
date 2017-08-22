using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    public class MyException : Exception
    {
        public string methodname { get; }
        public MyException(string msg,string _methodname) : base(msg)
        {
            methodname = _methodname;
        }
        public MyException(string msg):base(msg){
            
            }
    }

    public class Methods
    {
        public void add(int n1,int n2)
        {
            int resadd = 0;
           
                resadd = n1 + n2;
            
                throw (new MyException("This is my exception"));
                Console.WriteLine("Add result:{0}",resadd);
            

            
        }

        public void sub(int n1, int n2)
        {
            int ressub = 0;
            try
            {
                ressub = n1 - n2;
                throw new MyException("Something wrong", "ExceptionDemo.Methods.sub(int, int)");

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void mul(int n1, int n2)
        {
            int resmul = 0;
            try
            {
                resmul = n1 * n2;
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }
        }

        public void div(int n1, int n2)
        {
            int resdiv = 0;
            try
            {
                resdiv = n1 / n2;
            }
            catch (DivideByZeroException e)
            {

                Console.WriteLine(e);
            }
        }

    }
}
