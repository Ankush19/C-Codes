using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
    


        public EmployeeResponse GetEmployeeDetails(EmployeeRequest request)
        {
            if(request.key=="Admin")
            {
                Employee empdetails = new Employee();
                List<Employee> mylist = new List<Employee>();
                mylist.Add(new admin { Aid = 1, Age = 21, Name = "sss", Salary = 45432 });
                mylist.Add(new admin { Aid = 2, Age = 22, Name = "aas", Salary = 454333});

                mylist.Add(new manager { Mid = 1, Age = 21, Name = "sss", Salary = 45432 });
                mylist.Add(new manager { Mid = 2, Age = 22, Name = "aas", Salary = 454333 });


                empdetails.Name = "Ankush";
                empdetails.Age = 21;
                empdetails.Salary = 37500;
                Logger.log(loginfo.debug,"this is debug message");
                Logger.log(loginfo.error, "this is error message");
                Logger.log(loginfo.information, "this is info message");

                return new EmployeeResponse() { CompanyName = "Xoriant", Emp = mylist };

            }
            return null;


        }
    }
}
