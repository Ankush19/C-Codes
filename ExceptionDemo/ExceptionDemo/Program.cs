using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ExceptionDemo
{
    class Program
    {
        
        public void division(int num1,int num2)
        {
            var result=0;
            try
            {
                result = num1 / num2;

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception", e);
            }
            finally
            {
                Console.WriteLine("Result:{0}",result);
            }
        }
        static void Main(string[] args)
        {
            //Program p = new Program();
            //p.division(12,0);
            //Temperature t = new Temperature();
            //try
            //{
            //    t.showtemp();
            //}
            //catch (TempIsZeroException e)
            //{
            //    Console.WriteLine( e);
            //}
            Methods m = new Methods();
            int count = 0;
            while ( count<100)
            {
                int num1=0, num2=0;

                Console.WriteLine("Enter two numbers");
                try
                {
                    // char c = 'a';
                    //DateTime d = Convert.ToDateTime(c);
                    //m.add(2,3);
                    num1 = Int32.Parse(Console.ReadLine());
                    num2 = Int32.Parse(Console.ReadLine());

                }

                catch (FormatException e)
                {

                    Console.WriteLine(e);
                }
                catch (InvalidCastException e)
                {
                    Console.WriteLine(e);
                }
                catch (NullReferenceException e)

                {
                    Console.WriteLine(e);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                Console.WriteLine("Enter ur choice");
                Console.WriteLine("Add");
                Console.WriteLine("Subtract");
                Console.WriteLine("Multiply");
                Console.WriteLine("Divsision");

                int ch = Int32.Parse(Console.ReadLine());
                switch (ch)
                {
                    case 1:
                        try
                        {
                            try
                            {
                                m.add(num1, num2);
                            }

                            catch (MyException e)
                            {
                                throw new Exception("This is another exception" , e);
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.InnerException);
                        }
                        break;

                    case 2:
                        try
                        {
                            m.sub(num1, num2);
                        }
                        catch (MyException e)
                        {
                            Console.WriteLine(e.methodname);
                        }
                        break;

                    case 3:
                        m.mul(num1, num2);
                        break;

                    case 4:
                        m.div(num1, num2);
                        break;


                }
                count++;
            }

            Console.ReadLine();
        }
    }
}
