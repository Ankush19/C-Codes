﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IStudent
    {

        [OperationContract]
        List<Student> GetStudents();

       
        Student GetStudentById(int id);
        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Student
    {
       
        [DataMember]
        public int Id
        {
            get ;
            set ;
        }

        [DataMember]
        public string Name
        {
            get;
            set;
        }
    }
}
