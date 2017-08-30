using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataFirstApproach;

namespace DataConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var Empobj = new Emp1Entities())
            {
                var emp = new TableEmp();
                //emp.Empid = 1;
                //emp.Name = "Emp1";
                //emp.Salary = 10000;

                //emp = new TableEmp();
                //emp.Empid = 2;
                //emp.Name = "Emp1";
                //emp.Salary = 10000;
                //Empobj.TableEmps.Add(emp);


                //emp = new TableEmp();
                //emp.Empid = 3;
                //emp.Name = "Emp1";
                //emp.Salary = 10000;
                //Empobj.TableEmps.Add(emp);

                //for (int i = 0; i < 5; i++)
                //{

                //}

                //  TableEmp Empobj1 = Empobj.TableEmps.First(i => i.Empid == 2);
                //  Empobj1.Name = "Emp2";
                //  Empobj1.Salary = 223223;
                ////  Console.WriteLine(Empobj1.Name);
                //  Empobj.SaveChanges();

                //  TableEmp Empobj2 = Empobj.TableEmps.First(i => i.Empid == 3);
                //  Empobj.TableEmps.Remove(Empobj2);
                //  Empobj.SaveChanges();
                //  //Empobj.TableEmps.Add(emp);

                var emp3obj = Empobj.TableEmps;
                foreach (var item in emp3obj)
                {

                }
                //Empobj.SaveChanges();

                Console.WriteLine("Record inserted");
            }
            Console.ReadLine();
        }
    }
}
