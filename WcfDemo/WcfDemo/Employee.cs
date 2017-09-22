using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web;

namespace WcfDemo
{

    [MessageContract]
    public class EmployeeRequest
    {
        [MessageHeader]
        public string key;

        [MessageBodyMember]
        public int Empid;
    }

    [MessageContract]
    public class EmployeeResponse
    {
        [MessageHeader]
        public string CompanyName;

        [MessageBodyMember]
        public List<Employee> Emp;
    }


    [DataContract]
    [KnownType(typeof(admin))]
    [KnownType(typeof(manager))]
    public class Employee
    {
        private string m_name;
        private int m_age;
        private int m_salary;

        [DataMember]
        public int Age{
            get { return m_age; }
            set { m_age = value; }
        }

        [DataMember]
        public string Name {
            get { return m_name; }
            set { m_name = value; }
        }

        [DataMember]
        public int Salary{
            get { return m_salary; }
            set { m_salary = value; }
        }
}

    public class manager : Employee
    {
        
        private int managerid;

        [DataMember]
        public int Mid
        {
            get { return managerid; }
            set { managerid = value; }
        }
    }

    public class admin : Employee
    {

        private int adminid;

        [DataMember]
        public int Aid
        {
            get { return adminid; }
            set { adminid = value; }
        }
    }

}
