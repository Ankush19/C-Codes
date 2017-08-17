using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assigment6
{
    class Program
    {
        public delegate void CalculateSimpleInterest(int principal, int rate, int years);
        static void Main(string[] args)
        {
            Program p = new Program();
            CallDelegates(p);
            Func<int, int, int, int> func1 = p.GetTotalInterest1;
            Console.WriteLine("Using func");
            Console.WriteLine(func1(12,12,2));
            Console.ReadLine();

            Action<int, int, int> act1 = (pr, r, y) =>
            {
                Console.WriteLine("using action");
                int sim = ((pr * r * y) / 100);
                Console.WriteLine(sim);
                Console.ReadLine();
            };
            act1(100, 2, 4);

            Employee e = new Employee(1,"Ankush","Comp","sasda");
            e.add();
            Console.ReadLine();
        }

        
        public static void CallDelegates(Program p)
        {
            CalculateSimpleInterest calc1 = new CalculateSimpleInterest(p.GetTotalInterest);
            calc1(100,12,3);

            calc1 += new CalculateSimpleInterest(p.GetInterestRatePerYear);
            calc1(4, 3, 3);
            CalculateSimpleInterest calc2 = delegate (int principal, int rate, int years)
              {
                  int sim = principal * rate * years / 100;
                  Console.WriteLine("Anonymous method");
                  Console.WriteLine(sim);
                  Console.ReadLine();
              };
            calc2(300,45,5);

            CalculateSimpleInterest calc3 = (prin, rate, years) =>
              {
                  int sim = prin * rate * years / 100;
                  Console.WriteLine("Lambda method");
                  Console.WriteLine(sim);
                  Console.ReadLine();
              };
            calc3(400,1,1);
            
        }

        public void GetTotalInterest(int principal,int rate, int years)
        {
            int simpleInterest = (principal * rate * years) / 100;
            Console.WriteLine("Instance method");

            Console.WriteLine(simpleInterest);
            Console.ReadLine();
        }

        public void GetInterestRatePerYear(int principal, int interest, int years)
        {
            int rate = (principal * interest * years);
            Console.WriteLine("rate:"+rate);
        }
        public int GetTotalInterest1(int principal, int rate, int years)
        {
            return principal * rate * years;
        }
    }

    
}
