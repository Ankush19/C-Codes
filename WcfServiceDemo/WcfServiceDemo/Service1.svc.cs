using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service1 : IStudent
    {
        private List<Student> _student = new List<Student>
        {
            new Student { Name="Abs",Id=1},
            new Student { Name="Abc",Id=2}

        };
        
        public List<Student> GetStudents()
        {
            return _student;
        }

        public Student GetStudentById(int id)
        {
            return _student.Where(a => a.Id == id).FirstOrDefault();
        }

        
    }
}
